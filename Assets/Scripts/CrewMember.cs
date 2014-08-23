using UnityEngine;
using System.Collections;

public class CrewMember : MonoBehaviour 
{
	private bool _isSelected = false;

	void OnMouseDown()
	{
		var mousePosition = Input.mousePosition;
		_isSelected = true;
	}
}
