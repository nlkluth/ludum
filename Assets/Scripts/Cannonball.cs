using UnityEngine;
using System.Collections;

public class Cannonball : MonoBehaviour 
{
	public float Speed { get; set; }

	void Awake()
	{
		Speed = 12f;
	}
	
	void Start ()
	{
		rigidbody2D.velocity = transform.up * Speed;
	}
}