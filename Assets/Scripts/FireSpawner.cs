using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    public GameObject firePrefab;  // Prefab do fogo
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;
    public float spawnRadius = 5f;

    private float spawnTimer;

    void Start()
    {
        // Inicia o spawn do primeiro fogo
        spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            SpawnFire();
            spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);  // Próximo spawn
        }
    }

    void SpawnFire()
    {
        // Posição aleatória na tela
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnRadius, spawnRadius),
            Random.Range(-spawnRadius, spawnRadius),
            0f);

        Instantiate(firePrefab, randomPosition, Quaternion.identity);
    }
}
