using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed;
	public float rotationSpeed;
	public float maxDistance;
	public float powerUpCoolDown = 3.0f;
	
	private Transform _target;
	private Transform localTransform;
	private float _timeStamp = 0.0f;
	
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

	void OnDestroy()
	{
		if (Random.value > 0.8 && Time.time > _timeStamp)
		{
			_timeStamp = Time.time + powerUpCoolDown;
			// instantiate powerup
		}
	}
}
