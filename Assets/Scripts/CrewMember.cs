using UnityEngine;
using System.Collections;

public class CrewMember : MonoBehaviour 
{
	void OnMouseDown()
	{
		var mousePosition = Input.mousePosition;
		showSelect();
	}

	private void showSelect()
	{
		Debug.Log ("add selected look");
	}
}
