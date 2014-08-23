using UnityEngine;
using System.Collections;

public class Overlay : MonoBehaviour {
	public Transform overlayCamera;
	public float locationX;
	public float locationY;

	private bool open = false;

	void OnMouseDown()
	{
		openOrCloseOverlay();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.F)) 
		{
			openOrCloseOverlay();
		}
	}

	private void openOrCloseOverlay()
	{
		open = !open;

		if (open)
		{
			Instantiate(overlayCamera, new Vector2(locationX, locationY), Quaternion.identity);
			return;
		}
	}
}
