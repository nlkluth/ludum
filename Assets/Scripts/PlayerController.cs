using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;

}

public class PlayerController : MonoBehaviour 
{

	public float speed;
	///public float tilt;
	public Boundary boundary;
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		rigidbody2D.velocity = movement * speed;

		rigidbody2D.position = new Vector3
		(
			Mathf.Clamp (rigidbody2D.position.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp (rigidbody2D.position.y, boundary.yMin, boundary.yMax),
			0.0f
		);

		///rigidbody.rotation = Quaternion.Euler (0.0f, rigidbody.velocity.y * -tilt, 0.0f);
	}
}
