using UnityEngine;
using System.Collections;

public class Overlay : MonoBehaviour
{
	public Transform overlayCamera;
	public float locationX;
	public float locationY;

	private bool _open = false;

	void OnMouseDown()
	{
		OpenOrCloseOverlay();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.F)) 
		{
			OpenOrCloseOverlay();
		}
	}

	private void OpenOrCloseOverlay()
	{
		_open = !_open;

		if (_open)
		{
			Instantiate(overlayCamera, new Vector2(locationX, locationY), Quaternion.identity);
			return;
		}

		BoatOverlay.DestroyOverlay();
		CrewMember.DeselectCrew();
	}
}
