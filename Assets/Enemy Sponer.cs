using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject EnemyPrefab;

    void Start()
    {
        // ��b�Ԋu�Ŏ��s����
        InvokeRepeating("Spawn", 1f, 1f);
    }

    // Enemy�𐶐�����B
    private void Spawn()
    {
        // Y���������_���ɂ��Đ�������B
        Vector2 randomPos = new Vector2(transform.position.x, Random.Range(-5f, 5f));

        Instantiate(EnemyPrefab, randomPos, transform.rotation);
    }
}
