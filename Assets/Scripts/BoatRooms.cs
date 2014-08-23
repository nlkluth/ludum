using UnityEngine;
using System.Collections;

public class BoatRooms : MonoBehaviour 
{
	private GameObject[] _crewMembers;

	void Start()
	{
		_crewMembers = GameObject.FindGameObjectsWithTag("CrewMember");
	}

	void OnMouseDown()
	{
		var mousePosition = Input.mousePosition; 
		Debug.Log ("click!");

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
