using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour
{
	public int SpecialCount { get; set; }
	private GameObject _player;

	void Awake()
	{
		_player = gameObject;
	}

	public void AddPowerUp(PowerUpType powerUp)
	{
		if (powerUp == PowerUpType.Special)
    		{
		      	SpecialCount++;
			return;
		}
		return;
	}
}
