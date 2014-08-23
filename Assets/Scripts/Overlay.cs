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
