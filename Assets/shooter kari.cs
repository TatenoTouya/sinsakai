using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float Bulletspeed = 10.0f; // �e�̑��x
    public float BulletLifetime = 3.0f;
    public GameObject BulletObj; // �e�̃v���n�u

    private bool itemCollected = false; // �A�C�e�����擾���ꂽ���ǂ����̃t���O

    // Update is called once per frame
    void Update()
    {
        // �{�^�����������Ƃ�
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet(); // �ʏ�̒e�𔭎�
        }

        // �A�C�e�����擾���ꂽ�ꍇ�A��������������ꔭ�̒e�𔭎˂���
        if (itemCollected)
        {
            ShootAdditionalBullet();
        }
    }

    // �ʏ�̒e�𔭎˂��郁�\�b�h
    private void ShootBullet()
    {
        GameObject bulletInstance = Instantiate(BulletObj, transform.position, transform.rotation);
        Rigidbody2D bulletRigidbody = bulletInstance.GetComponent<Rigidbody2D>();
        if (bulletRigidbody != null)
        {
            bulletRigidbody.velocity = transform.right * Bulletspeed; // �Q�[���I�u�W�F�N�g�̉E�����ɑ��x��ݒ�
        }
        Destroy(bulletInstance, BulletLifetime);
    }

    // �ǉ��̒e�𔭎˂��郁�\�b�h
    private void ShootAdditionalBullet()
    {
        GameObject additionalBullet = Instantiate(BulletObj, transform.position - new Vector3(0f, 0.5f, 0f), transform.rotation);
        Rigidbody2D additionalBulletRigidbody = additionalBullet.GetComponent<Rigidbody2D>();
        if (additionalBulletRigidbody != null)
        {
            additionalBulletRigidbody.velocity = transform.right * Bulletspeed; // �Q�[���I�u�W�F�N�g�̉E�����ɑ��x��ݒ�
        }
        Destroy(additionalBullet, BulletLifetime);
    }

    // �A�C�e�����擾���ꂽ�Ƃ��ɌĂ΂�郁�\�b�h�i�O������Ăяo���z��j
    public void OnItemCollected()
    {
        itemCollected = true;
    }
}
