using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject EnemyPrefab;

    void Start()
    {
        // 一秒間隔で実行する
        InvokeRepeating("Spawn", 1f, 1f);
    }

    // Enemyを生成する。
    private void Spawn()
    {
        // Y軸をランダムにして生成する。
        Vector2 randomPos = new Vector2(transform.position.x, Random.Range(-5f, 5f));

        Instantiate(EnemyPrefab, randomPos, transform.rotation);
    }
}
