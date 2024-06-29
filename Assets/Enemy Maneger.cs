using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float moveSpeed = 7f;
    public GameObject[] itemPrefabs; // アイテムのプレハブを格納する配列
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>(); // ScoreManagerをシーン内から探す
    }

    private void Update()
    {
        Move();
        Delete();
    }

    // 左に移動させる
    private void Move()
    {
        transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
    }

    // 画面外に出たら消す
    private void Delete()
    {
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject); // 衝突したプレイヤーを破壊
            Destroy(gameObject); // 自身（敵）を破壊
        }
    }
    private void OnDestroy()
    {
        // ランダムにアイテムを生成する
        SpawnRandomItem();
    }

    // ランダムにアイテムを生成するメソッド
    private void SpawnRandomItem()
    {
        if (itemPrefabs.Length > 0)
        {
            int randomIndex = Random.Range(0, itemPrefabs.Length);
            GameObject itemPrefab = itemPrefabs[randomIndex];
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
        }
    }
}