using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
	void OnTriggerExit2D(Collider2D collider)
	{
		if (collider.transform.parent != null && collider.transform.parent.gameObject != null)
		{
			Destroy(collider.transform.parent.gameObject);
			return;
		}

		Destroy(collider.gameObject);
	}
}
