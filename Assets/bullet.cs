using UnityEngine;

public class LazerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // �e�e�̑��x

    void Update()
    {
        Move();
    }

    private void Move()
    {
        // ���݂̈ʒu�ɑ��x�����Z���Ĉړ�����
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
