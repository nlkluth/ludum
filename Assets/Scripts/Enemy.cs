using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed;
	public float rotationSpeed;
	public float maxDistance;
	
	private Transform _target;
	private Transform localTransform;
	
	void Awake()
	{
		localTransform = transform;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			_target = collider.transform;
			speed = speed / 2;
		}
	}
	
	void Update() 
	{
		if (_target != null && Vector3.Distance(_target.position, localTransform.position) <= maxDistance)
		{
			speed = speed / 2;
		}

		localTransform.Translate (Vector3.right * Time.deltaTime * speed);
	}
}
