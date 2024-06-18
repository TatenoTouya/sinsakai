using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度")]
    [SerializeField]
    private float _speed = 1f;

    //2Dの場合は「Rigidbody2D」を使う
    /// <summary> 物理演算を行うもの </summary>
    private Rigidbody2D _rb = default;

    private void Start()
    {
        if (!gameObject.TryGetComponent(out _rb))
        {
            _rb = gameObject.AddComponent<Rigidbody2D>();
        }
        _rb.gravityScale = 0f; // 重力を無効化する
    }

    private void Update()
    {
        //縦横方向の入力を受付、移動する
        var hol = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");

        _rb.velocity = new Vector2(hol, ver) * _speed;
    }

    /// <summary> 速度上昇 </summary>
    /// <param name="value"> どれくらい速度を上げるか </param>
    public void SpeedUp(float value)
    {
        _speed += value;
        Debug.Log($"SpeedUp!! {_speed}");
    }
}