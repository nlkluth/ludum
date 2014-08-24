using UnityEngine;
using System.Collections;

public class BoatOverlay : MonoBehaviour
{
	private static GameObject _boatOverlay;

	public static void DestroyOverlay()
	{
		_boatOverlay = GameObject.FindGameObjectWithTag("OverlayCamera");
		GameObject.Destroy(_boatOverlay);
	}
}
