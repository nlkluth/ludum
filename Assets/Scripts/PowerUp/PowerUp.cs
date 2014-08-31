using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour
{
	public PowerUpType powerUpType;

	private GameObject player;
	private PlayerInventory playerInventory;
	
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerInventory = player.GetComponent<PlayerInventory>();
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			playerInventory.AddPowerUp(this.PowerUpType);
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