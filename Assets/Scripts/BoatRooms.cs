using UnityEngine;
using System.Collections;

public class BoatRooms : MonoBehaviour 
{
	private GameObject[] _crewMembers;

	void Start()
	{
		_crewMembers = GameObject.FindGameObjectsWithTag("CrewMember");
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			MoveCrewToRoom();
		}
	}

	private void MoveCrewToRoom()
	{
		var mousePosition = Input.mousePosition; 

		foreach (GameObject crewmember in _crewMembers)
		{
			var current = crewmember.GetComponent<CrewMember>();
			if (current.isSelected)
			{
				current.MoveToMousePosition(mousePosition);
			}
		}
	}
}
