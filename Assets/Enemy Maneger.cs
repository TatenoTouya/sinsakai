using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float moveSpeed = 7f;
    public GameObject[] itemPrefabs; // �A�C�e���̃v���n�u���i�[����z��
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>(); // ScoreManager���V�[��������T��
    }

    private void Update()
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
            Destroy(collision.gameObject); // �Փ˂����v���C���[��j��
            Destroy(gameObject); // ���g�i�G�j��j��
        }
    }
    private void OnDestroy()
    {
        // �����_���ɃA�C�e���𐶐�����
        SpawnRandomItem();
    }

    // �����_���ɃA�C�e���𐶐����郁�\�b�h
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