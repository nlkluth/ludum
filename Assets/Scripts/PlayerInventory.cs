using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour
{
	public int SpecialCount { get; set; }
	public float Speed { get; set; }
	public int WeaponPower { get; set; }
	public float WeaponSpeed { get; set; }

	void Awake()
	{
		SpecialCount = 0;
		Speed = 3;
		WeaponPower = 1;
		WeaponSpeed = 1;
	}

	public void AddPowerUp(PowerUpType powerUp)
	{
		if (powerUp == PowerUpType.Special)
    		{
			if (SpecialCount > 3) 
			{
				return;
			}

		      	SpecialCount++;
		}


		if (powerUp == PowerUpType.Speed)
		{
			Speed+= 0.2f;
		}
	}
}
