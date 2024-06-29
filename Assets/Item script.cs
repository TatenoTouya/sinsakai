using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float moveSpeed = 3f; // �A�C�e���̈ړ����x

    // Update is called once per frame
    void Update()
    {
        MoveLeft(); // ���Ɉړ����郁�\�b�h���Ăяo��
    }

    // ���Ɉړ����郁�\�b�h
    private void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    // �v���C���[�ɓ��������Ƃ��ɌĂ΂�郁�\�b�h
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // �v���C���[�ɓ���������ABullets �X�N���v�g�����I�u�W�F�N�g���擾����
            Bullets bulletsScript = collision.gameObject.GetComponent<Bullets>();
            if (bulletsScript != null)
            {
                bulletsScript.OnItemCollected(); // Bullets �X�N���v�g���̃t���O�� true �ɂ��郁�\�b�h���Ăяo��
            }

            // �A�C�e�����̂�j������i�C�Ӂj
            Destroy(gameObject);
        }
    }
}
