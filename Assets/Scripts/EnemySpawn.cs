using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour 
{
	public GameObject EnemyPrefab;
	public Vector3 spawnValues; 
	
	public float enemyStartWait; 
	public float enemySpawnWait; 
	public float enemyWaveCount; 
	public float enemyWaveWait;
	
	void Start()
	{
		StartCoroutine(SpawnEnemies());
	}
	
	IEnumerator SpawnEnemies()
	{
		yield return new WaitForSeconds(enemyStartWait);
		
		while (true)
		{
			for (int i = 0; i < enemyWaveCount; i++)
			{
				Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z));
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate(EnemyPrefab, spawnPosition, spawnRotation);
				yield return new WaitForSeconds(enemySpawnWait);
			}
			
			yield return new WaitForSeconds(enemyWaveWait);
		}
	}	
}
