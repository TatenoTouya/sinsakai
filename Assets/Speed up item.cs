using UnityEngine;

/// <summary> ���x�㏸�A�C�e�� </summary>
public class Item : MonoBehaviour
{
    [Header("���x�㏸�l")]
    [SerializeField]
    private float _speedUpValue = 2f;

    //2D�̏ꍇ�́AOnCollisionEnter2D������
    /// <summary> �����蔻�肪�N�������Ɏ��s����� </summary>
    private void OnCollisionEnter2D(Collision2D coll)
    {
        //if (collision.gameObject.TryGetComponent(out Player player)) { player.SpeedUp(_speedUpValue); Destroy(gameObject); }

        //�Փ˂����I�u�W�F�N�g���uPlayer�v�Ƃ������O�̃^�O�������Ă��邩����
        if (coll.gameObject.tag == "Player")
        {
            //�����������ꍇ�APlayer�̃f�[�^���擾���Ă���
            //gameObject.GetComponent<ComponentName>(); �Ŏ擾�\
            var playerComponent = coll.gameObject.GetComponent<Player>();
            playerComponent.SpeedUp(_speedUpValue);
        }
        Destroy(this.gameObject);
    }
}