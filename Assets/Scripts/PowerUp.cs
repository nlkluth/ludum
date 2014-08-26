using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour
{
	public PowerUpType PowerUp { get; set; }

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
			playerInventory.AddPowerUp(this.PowerUp);
			Destroy(gameObject);
		}
	}
}
