using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour
{
	public PowerUpType powerUpType;
	public float speed = 1;

	private GameObject player;
	private PlayerInventory playerInventory;
	private Transform localTransform;
	
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerInventory = player.GetComponent<PlayerInventory>();
		localTransform = transform;
	}

	void Update()
	{
		localTransform.Translate(Vector3.right * Time.deltaTime * speed);
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			playerInventory.AddPowerUp(powerUpType);
			Destroy(gameObject);
		}
	}
}

public enum PowerUpType
{
	Weapon,
	Armor,
	Special,
	Speed,
	None
}