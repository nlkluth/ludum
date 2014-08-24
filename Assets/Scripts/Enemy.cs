using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float moveSpeed;
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
			Debug.Log (_target);
		}
	}
	
	//	void Update () 
	//	{
	//		localTransform.rotation = Quaternion.Slerp(localTransform.rotation, Quaternion.LookRotation(_target.position - localTransform.position), rotationSpeed * Time.deltaTime);
	//		
	//		if (Vector3.Distance(_target.position, localTransform.position) > maxDistance)
	//		{
	//			localTransform.position += localTransform.forward * moveSpeed * Time.deltaTime;
	//		}
	//	}
}
