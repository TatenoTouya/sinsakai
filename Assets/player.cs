using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("�ړ����x")]
    [SerializeField]
    private float _speed = 1f;

    //2D�̏ꍇ�́uRigidbody2D�v���g��
    /// <summary> �������Z���s������ </summary>
    private Rigidbody2D _rb = default;

    private void Start()
    {
        if (!gameObject.TryGetComponent(out _rb))
        {
            _rb = gameObject.AddComponent<Rigidbody2D>();
        }
        _rb.gravityScale = 0f; // �d�͂𖳌�������
    }

    private void Update()
    {
        //�c�������̓��͂���t�A�ړ�����
        var hol = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");

        _rb.velocity = new Vector2(hol, ver) * _speed;
    }

    /// <summary> ���x�㏸ </summary>
    /// <param name="value"> �ǂꂭ�炢���x���グ�邩 </param>
    public void SpeedUp(float value)
    {
        _speed += value;
        Debug.Log($"SpeedUp!! {_speed}");
    }
}