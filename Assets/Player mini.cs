using UnityEngine;

public class MiniPlayerController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;    // �e�̃v���n�u
    [SerializeField] Vector3 offsetPos;          // �v���C���[����̃I�t�Z�b�g�ʒu
    GameObject player;                           // �v���C���[�I�u�W�F�N�g
    public float bulletSpeed = 10.0f;             // �e�̑��x
    public float bulletLifetime = 3.0f;           // �e�̎���

    void Start()
    {
        // �v���C���[�I�u�W�F�N�g�𖼑O�Ō������Ď擾����
        player = GameObject.Find("player");
    }

    void Update()
    {
        // �{�^�����������Ƃ��ɒe�𔭎˂���
        if (Input.GetButtonDown("Fire1"))
        {
            // ���݂̃Q�[���I�u�W�F�N�g�̈ʒu�ƌ����Œe�𐶐�����
            GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // �e�̑��x��ݒ肷��
            Rigidbody2D bulletRigidbody = bulletInstance.GetComponent<Rigidbody2D>();
            if (bulletRigidbody != null)
            {
                bulletRigidbody.velocity = transform.right * bulletSpeed; // �Q�[���I�u�W�F�N�g�̉E�����ɑ��x��ݒ�
            }

            // �e�̎�����ݒ肵�A��莞�Ԍ�ɔj������
            Destroy(bulletInstance, bulletLifetime);
        }
    }
    public void SetOffsetPos(Vector3 offset)
    {
        transform.localPosition = offset;
    }
}
