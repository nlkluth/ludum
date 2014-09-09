using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
	void OnTriggerExit2D(Collider2D collider)
	{
		if (transform.parent.gameObject)
		{
			Destroy(collider.transform.parent.gameObject);
			return;
		}

		Destroy(collider.gameObject);
	}
}
