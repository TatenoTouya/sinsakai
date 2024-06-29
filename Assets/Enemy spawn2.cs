using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] itemPrefabs; // �A�C�e���̃v���n�u���i�[����z��
    public float minY = -5f; // Y���̍ŏ��l
    public float maxY = 5f;  // Y���̍ő�l

    void Start()
    {
        // ��b�Ԋu�Ŏ��s����
        InvokeRepeating("Spawn", 0.8f, 0.8f);
    }

    // Enemy�𐶐�����B
    private void Spawn()
    {
        // Y���������_���ɂ��Đ������邪�A������������
        float randomY = Random.Range(minY, maxY);
        Vector2 randomPos = new Vector2(transform.position.x, randomY);

        // �����_���ɃA�C�e����I������
        int randomIndex = Random.Range(0, itemPrefabs.Length);
        GameObject itemPrefab = itemPrefabs[randomIndex];

        Instantiate(itemPrefab, randomPos, transform.rotation);
    }
}