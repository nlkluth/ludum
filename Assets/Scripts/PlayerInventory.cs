using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour
{
	public Player player;
	public int SpecialCount { get; set; }

	public void AddPowerUp(PowerUpType powerUp)
	{
		if (powerUp == PowerUpType.Special)
    		{
		      	return SpecialCount++;
		}

    		player.IncreaseStat(powerUp);
	}
}
