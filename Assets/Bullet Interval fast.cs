using UnityEngine;

/// <summary> ���x�㏸�A�C�e�� </summary>
public class BulletInterval : MonoBehaviour
{
    [Header("���ˊԊu")]
    [SerializeField]
    private float _BulletIntervalUpValue = 2f;
    [Header("�����ړ����x")]
    [SerializeField]
    private float _moveSpeed = 3f;

    //2D�̏ꍇ�́AOnCollisionEnter2D������
    /// <summary> �����蔻�肪�N�������Ɏ��s����� </summary>
    /// 
    private void Update()
    {
        transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        //if (collision.gameObject.TryGetComponent(out Player player)) { player.SpeedUp(_speedUpValue); Destroy(gameObject); }

        //�Փ˂����I�u�W�F�N�g���uPlayer�v�Ƃ������O�̃^�O�������Ă��邩����
        if (coll.gameObject.tag == "Player")
        {
            //�����������ꍇ�APlayer�̃f�[�^���擾���Ă���
            //gameObject.GetComponent<ComponentName>(); �Ŏ擾�\
            var BulletshoterComponent = coll.gameObject.GetComponent<Bulletshoter>();
            BulletshoterComponent.ShootIntervalfast(_BulletIntervalUpValue);
        }
        Destroy(this.gameObject);
    }
}