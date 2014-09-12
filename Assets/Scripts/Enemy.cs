using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed;
	public float rotationSpeed;
	public float maxDistance;
	public float powerUpCoolDown = 3.0f;
	public Transform speedPowerUp;
	public Transform weaponPowerUp;
	public Transform armorPowerUp;
	
	private Transform _target;
	private Transform localTransform;
	private float _timeStamp = 0.0f;
	private bool isQuitting = false;
	
	void Awake()
	{
		localTransform = transform;
	}

	void Start()
	{
		speed = Random.Range(1, speed);
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			_target = collider.transform;
			speed = speed / 2;
		}
	}
	
	void Update() 
	{
		if (_target != null && Vector3.Distance(_target.position, localTransform.position) <= maxDistance)
		{
			speed = speed / 2;
		}

		localTransform.Translate(Vector3.right * Time.deltaTime * speed);
	}

	void OnDestroy()
	{
		if (Random.value > 0.8 && Time.time > _timeStamp)
		{
			_timeStamp = Time.time + powerUpCoolDown;
			DropPowerUp();
		}
	}

	void OnApplicationQuit()
	{
		isQuitting = true;
	}

	public void TakeDamage()
	{
		Destroy(gameObject);
	}

	private void DropPowerUp()
	{
		if (!isQuitting)
		{
			var chance = Random.value; //TODO: do this better
			var powerup = speedPowerUp;

			if (chance > 0 && chance <= 0.3)
			{	
				powerup = weaponPowerUp;
			}

			if (chance > 0.3 && chance <= 0.6)
			{
				powerup = armorPowerUp;
			}

			Instantiate(speedPowerUp, new Vector2(localTransform.position.x, localTransform.position.y), Quaternion.identity);
		}
	}
}
