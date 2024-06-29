using UnityEngine;

public class PlayerScoreArea : MonoBehaviour
{
    ScoreManager scoreManager = null;      // �X�R�A�Ǘ�

    void Start()
    {
        // �X�R�A�Ǘ��I�u�W�F�N�g���擾����
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    // �q�b�g���Ă���Ƃ����t���[���Ăяo�����
    void OnTriggerStay2D(Collider2D other)
    {
        // �G�̒e�Ƀq�b�g
        if (other.gameObject.CompareTag("enemy_bullet"))
        {
            // �X�R�A�����Z
            if (scoreManager)
            {
                scoreManager.AddScore(1);
            }
        }
    }
}