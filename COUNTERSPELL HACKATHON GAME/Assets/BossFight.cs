using UnityEngine;

public class BossFight : MonoBehaviour
{
    public int bossHealth;
    public float timeBetweenEnemySpawns;
    private float timeLeftUntilNextEnemySpawn;

    public GameObject enemyPrefab;

    private void Start()
    {
        timeLeftUntilNextEnemySpawn = timeBetweenEnemySpawns;
    } 

    private void Update()
    {
        timeLeftUntilNextEnemySpawn -= Time.deltaTime;

        if (timeLeftUntilNextEnemySpawn <= 0) {
            Instantiate(enemyPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            Instantiate(enemyPrefab, transform.position + new Vector3(0, -1, 0), Quaternion.identity);
            Instantiate(enemyPrefab, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
            Instantiate(enemyPrefab, transform.position + new Vector3(-1, 0, 0), Quaternion.identity);

            timeLeftUntilNextEnemySpawn = timeBetweenEnemySpawns;
        }
    }
}
