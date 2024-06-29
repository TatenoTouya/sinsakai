using UnityEngine;

public class EnemyManage : MonoBehaviour
{
    private int moveSpeed = 5;
    private ScoreManager scoreManager;
    public GameObject itemPrefab; // アイテムのプレハブ

    void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    void Update()
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
            Destroy(this.gameObject);
            Destroy(collision.gameObject);

            // アイテムを生成する
            SpawnItem();
        }
        if (scoreManager != null)
        {
            scoreManager.AddScore(100);
        }
    }

    // アイテムを生成するメソッド
    private void SpawnItem()
    {
        Instantiate(itemPrefab, transform.position, Quaternion.identity);
    }
}
