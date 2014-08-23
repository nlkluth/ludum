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
		Camera OverlayCamera = GameObject.FindGameObjectWithTag("OverlayCamera").GetComponent<Camera>();
		var mousePosition = OverlayCamera.ScreenToWorldPoint(Input.mousePosition);
		
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
