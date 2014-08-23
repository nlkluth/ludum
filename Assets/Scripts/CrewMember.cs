using UnityEngine;
using System.Collections;

public class CrewMember : MonoBehaviour 
{
	public bool isSelected;

	void OnMouseDown()
	{
		showSelect();
	}

	private void showSelect()
	{
		isSelected = true;
		Debug.Log ("add selected look");
	}

	public void MoveToMousePosition(Vector2 mousePosition)
	{
		Debug.Log ("clicked");
		Debug.Log (mousePosition);
	}
}
