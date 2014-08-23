using UnityEngine;
using System.Collections;

public class Overlay : MonoBehaviour {
	private bool open = false;

	void OnMouseDown()
	{
		openOrCloseOverlay();
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			openOrCloseOverlay();
		}
	}

	private void openOrCloseOverlay()
	{
		open = !open;

		if (open)
		{
			return;
		}
	}
}
