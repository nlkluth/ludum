using UnityEngine;
using System.Collections;

public class CrewMember : MonoBehaviour 
{
	public bool isSelected;
	public Sprite selectedSprite;
	public Sprite deselectedSprite;
	public float time;

	private bool _isMoving = false;
	private Vector3 _mousePosition;
	private static GameObject[] _crewMembers;
	private SpriteRenderer _spriteRender;

	void Start()
	{
		_crewMembers = GameObject.FindGameObjectsWithTag("CrewMember");
		_spriteRender = gameObject.GetComponent<SpriteRenderer>();
	}

	void Update()
	{
		if (_isMoving && transform.position != _mousePosition)
		{
			transform.position = Vector2.Lerp(transform.position, _mousePosition, time * Time.time);

		}

		if (_isMoving && transform.position == _mousePosition)
		{
			_isMoving = false;
		}

		if (!isSelected)
		{
			_spriteRender.sprite = deselectedSprite;
		}
		else
		{
			_spriteRender.sprite = selectedSprite;
		}
	}

	void OnMouseDown()
	{
		showSelect();
	}

	private void showSelect()
	{
		DeselectCrew();
		isSelected = !isSelected;
	}

	public void MoveToMousePosition(Vector3 mousePosition)
	{
		_isMoving = true;
		_mousePosition = mousePosition;
	}

	public static void DeselectCrew()
	{
		foreach(GameObject crewmember in _crewMembers)
		{
			var crewScript = crewmember.GetComponent<CrewMember>();
			crewScript.isSelected = false;
		}
	}
}
