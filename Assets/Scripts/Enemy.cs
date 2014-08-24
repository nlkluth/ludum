using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed;
	public float rotationSpeed;
	public float maxDistance;
	
	private Transform _target;
	private Transform localTransform;
	private bool _cruising = true;
	
	void Awake()
	{
		localTransform = transform;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			_target = collider.transform;
			_cruising = false;
		}
	}
	
	void Update () 
	{
		if (_cruising)
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed);
			return;
		}

		localTransform.rotation = Quaternion.Slerp(localTransform.rotation, Quaternion.LookRotation(_target.position - localTransform.position), rotationSpeed * Time.deltaTime);
		
		if (Vector3.Distance(_target.position, localTransform.position) > maxDistance)
		{
			localTransform.position += localTransform.forward * speed * Time.deltaTime;
		}
	}
}
