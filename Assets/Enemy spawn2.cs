using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] itemPrefabs; // アイテムのプレハブを格納する配列
    public float minY = -5f; // Y軸の最小値
    public float maxY = 5f;  // Y軸の最大値

    void Start()
    {
        // 一秒間隔で実行する
        InvokeRepeating("Spawn", 0.8f, 0.8f);
    }

    // Enemyを生成する。
    private void Spawn()
    {
        // Y軸をランダムにして生成するが、制限をかける
        float randomY = Random.Range(minY, maxY);
        Vector2 randomPos = new Vector2(transform.position.x, randomY);

        // ランダムにアイテムを選択する
        int randomIndex = Random.Range(0, itemPrefabs.Length);
        GameObject itemPrefab = itemPrefabs[randomIndex];

        Instantiate(itemPrefab, randomPos, transform.rotation);
    }
}