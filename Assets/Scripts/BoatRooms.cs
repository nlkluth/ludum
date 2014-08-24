using UnityEngine;
using System.Collections;

[System.Serializable]
public class PseudoBounds
{
	public float xMax;
	public float yMax;
}

public class BoatRooms : MonoBehaviour 
{
	private GameObject[] _crewMembers;
	private Transform _transform;
	public PseudoBounds bounds;

	void Start()
	{	_transform = gameObject.GetComponent<Transform>();
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
		GameObject FindOverlayCamera = GameObject.FindGameObjectWithTag("OverlayCamera");
		if (FindOverlayCamera == null)
		{
			return;
		}

		Camera OverlayCamera = FindOverlayCamera.GetComponent<Camera>();

		var mousePosition = OverlayCamera.ScreenToWorldPoint(Input.mousePosition);

		if (mousePosition.x > _transform.position.x + bounds.xMax || mousePosition.x < _transform.position.x - bounds.xMax ||
			mousePosition.y > _transform.position.y + bounds.yMax || mousePosition.y < _transform.position.y - bounds.yMax)
		{
			return;	
		}
		
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
