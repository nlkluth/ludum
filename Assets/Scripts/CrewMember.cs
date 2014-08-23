﻿using UnityEngine;
using System.Collections;

public class CrewMember : MonoBehaviour 
{
	public bool isSelected;
	public Sprite selectedSprite;
	public Sprite deselectedSprite;
	public float time;

	private bool _isMoving = false;
	private Vector3 _mousePosition;

	void Update()
	{
		if (_isMoving && transform.position != _mousePosition)
		{
			transform.position = Vector2.Lerp(transform.position, _mousePosition, time * Time.deltaTime);

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
		var spriteRender = gameObject.GetComponent<SpriteRenderer>();
		isSelected = !isSelected;

		if (!isSelected)
		{
			spriteRender.sprite = deselectedSprite;
			return;
		}
		spriteRender.sprite = selectedSprite;
	}

	public void MoveToMousePosition(Vector3 mousePosition)
	{
		_isMoving = true;
		_mousePosition = mousePosition;
	}
}
