using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D collider) 
	{
		if (collider.tag == "Player")
		{
			Destroy(collider.gameObject);
			Destroy(transform.parent.gameObject);
		}
	}
}
