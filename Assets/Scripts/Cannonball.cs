using UnityEngine;
using System.Collections;

public class Cannonball : MonoBehaviour 
{
	public float speed;
	public Vector3 Direction { get; set; }

	void Start()
	{
		rigidbody2D.velocity = Direction;
	}
}
