using UnityEngine;

public class EnemyManage : MonoBehaviour
{
    private int moveSpeed = 5;
    private ScoreManager scoreManager;
    public GameObject itemPrefab; // �A�C�e���̃v���n�u

    void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        Move();
        Delete();
    }

    // ���Ɉړ�������
    private void Move()
    {
        transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
    }

    // ��ʊO�ɏo�������
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

            // �A�C�e���𐶐�����
            SpawnItem();
        }
        if (scoreManager != null)
        {
            scoreManager.AddScore(100);
        }
    }

    // �A�C�e���𐶐����郁�\�b�h
    private void SpawnItem()
    {
        Instantiate(itemPrefab, transform.position, Quaternion.identity);
    }
}
