using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour 
{	
	public Transform startPosition;
	public float speed;

	void Update()
	{
		transform.Translate(Vector3.right * Time.deltaTime * speed);
	}

	void OnBecameInvisible()
	{
		gameObject.transform.position = startPosition.position;
	}
}
