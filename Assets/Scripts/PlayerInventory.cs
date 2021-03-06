﻿using UnityEngine;
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
		WeaponSpeed = 5;
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

		if (powerUp == PowerUpType.Weapon)
		{
			UpdateWeaponPower();
		}

		if (powerUp == PowerUpType.Speed)
		{
			Speed+= 0.2f;
		}
	}

	private void UpdateWeaponPower()
	{
		if (WeaponPower % 10 == 0)
		{
			AddNewWeaponClass();
			return;
		}

		if (WeaponPower % 2 == 0)
		{
			WeaponSpeed -= 0.2f;
			return;
		}

		WeaponPower += 1;
	}

	private void AddNewWeaponClass()
	{
		return;
	}
}
