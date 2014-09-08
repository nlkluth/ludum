using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	public Enemy enemy;

	void Awake()
	{
		enemy = transform.parent.gameObject.GetComponent<Enemy>();
	}

	void OnTriggerEnter2D(Collider2D collider) 
	{
		if (collider.tag == "Player")
		{
			Destroy(collider.gameObject);
			Destroy(transform.parent.gameObject);
		}

		if (collider.tag == "Cannonball")
		{
			Destroy(collider.gameObject);
			enemy.TakeDamage();
		}
	}
}
