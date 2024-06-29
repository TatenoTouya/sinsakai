using UnityEngine;

public class Bulletshoter : MonoBehaviour
{
    public float _Bulletspeed = 10.0f; // �e�̑��x
    public float BulletLifetime = 3.0f;
    public GameObject BulletObj; // �e�̃v���n�u
    public float _ShootInterval = 0.2f; // ���ˊԊu�i�b�j

    private float _shootTimer = 0f; // ���˃^�C�}�[

    void Update()
    {
        // �^�C�}�[���X�V
        _shootTimer += Time.deltaTime;

        // �{�^�����������Ƃ����N�[���_�E�����Ԃ𒴂��Ă����甭��
        if (Input.GetButtonDown("Fire1") && _shootTimer >= _ShootInterval)
        {
            ShootBullet();
            _shootTimer = 0f; // �^�C�}�[���Z�b�g
        }
    }

    // �e�𔭎˂��郁�\�b�h
    private void ShootBullet()
    {
        Vector3 spawnPosition = transform.position + transform.right * 0.5f; // �����O���ɒ���
        GameObject bulletInstance = Instantiate(BulletObj, spawnPosition, transform.rotation);
        Rigidbody2D bulletRigidbody = bulletInstance.GetComponent<Rigidbody2D>();
        if (bulletRigidbody != null)
        {
            bulletRigidbody.velocity = transform.right * _Bulletspeed; // �Q�[���I�u�W�F�N�g�̉E�����ɑ��x��ݒ�
        }
        Destroy(bulletInstance, BulletLifetime);
    }

    // �e�̑��x���グ�郁�\�b�h
    public void BulletSpeedUp(float value)
    {
        _Bulletspeed += value;
        Debug.Log($"BulletSpeedUp!! {_Bulletspeed}");
    }
    public void ShootIntervalfast(float value)
    {
        _ShootInterval += value;
        Debug.Log($"_ShootIntervalUp!! {_ShootInterval}");
    }
}
