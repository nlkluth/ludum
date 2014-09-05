using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour
{
	public int SpecialCount { get; set; }
	public float Speed { get; set; }

	void Awake()
	{
		Speed = 3;
	}

	public void AddPowerUp(PowerUpType powerUp)
	{
		if (powerUp == PowerUpType.Special)
    		{
		      	SpecialCount++;
		}


		if (powerUp == PowerUpType.Speed)
		{
			Speed+= 0.2f;
		}
	}
}
