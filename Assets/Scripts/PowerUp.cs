using UnityEngine;
using System.Collections;

[System.Serializable]
public class PowerUpType
{

}

public class PowerUp : MonoBehaviour
{
	public PowerUpType powerUp;

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
			playerInventory.AddPowerUp(this.powerUp);
			Destroy(gameObject);
		}
	}
}
