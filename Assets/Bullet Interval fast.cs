using UnityEngine;

/// <summary> 速度上昇アイテム </summary>
public class BulletInterval : MonoBehaviour
{
    [Header("発射間隔")]
    [SerializeField]
    private float _BulletIntervalUpValue = 2f;
    [Header("自動移動速度")]
    [SerializeField]
    private float _moveSpeed = 3f;

    //2Dの場合は、OnCollisionEnter2Dがある
    /// <summary> 当たり判定が起きた時に実行される </summary>
    /// 
    private void Update()
    {
        transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        //if (collision.gameObject.TryGetComponent(out Player player)) { player.SpeedUp(_speedUpValue); Destroy(gameObject); }

        //衝突したオブジェクトが「Player」という名前のタグを持っているか判定
        if (coll.gameObject.tag == "Player")
        {
            //正しかった場合、Playerのデータを取得してくる
            //gameObject.GetComponent<ComponentName>(); で取得可能
            var BulletshoterComponent = coll.gameObject.GetComponent<Bulletshoter>();
            BulletshoterComponent.ShootIntervalfast(_BulletIntervalUpValue);
        }
        Destroy(this.gameObject);
    }
}