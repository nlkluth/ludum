using UnityEngine;
using System.Collections;

public class CrewMember : MonoBehaviour 
{
	public bool isSelected;

	private bool _isMoving = false;
	private Vector2 _mousePosition;

	void Update()
	{
		if (_isMoving && transform.position != _mousePosition)
		{
			transform.position = _mousePosition;
		}

		if (_isMoving && transform.position == _mousePosition)
		{
			_isMoving = false;
		}
	}

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
		_isMoving = true;
		_mousePosition = mousePosition;
	}
}
