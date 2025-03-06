using UnityEngine;

public class Snowfall : MonoBehaviour
{
    public GameObject snowflakePrefab;
    public int snowflakeCount = 100; // Số lượng tuyết
    public Vector2 spawnArea = new Vector2(20, 10); // Khu vực tuyết rơi

    void Start()
    {
        for (int i = 0; i < snowflakeCount; i++)
        {
            SpawnSnowflake();
        }
    }

    void SpawnSnowflake()
    {
        Vector3 spawnPos = new Vector3(
            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
            spawnArea.y,
            0
        );

        GameObject snowflake = Instantiate(snowflakePrefab, spawnPos, Quaternion.identity);

        Debug.Log($"Spawned Snowflake at {spawnPos}");

        if (snowflake.GetComponent<Rigidbody2D>() == null)
        {
            Rigidbody2D rb = snowflake.AddComponent<Rigidbody2D>();
            rb.gravityScale = 0.2f; // Điều chỉnh tốc độ rơi
        }

        Destroy(snowflake, 10f);
    }

}
