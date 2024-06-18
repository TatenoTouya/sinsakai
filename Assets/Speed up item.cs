using UnityEngine;

/// <summary> 速度上昇アイテム </summary>
public class Item : MonoBehaviour
{
    [Header("速度上昇値")]
    [SerializeField]
    private float _speedUpValue = 2f;

    //2Dの場合は、OnCollisionEnter2Dがある
    /// <summary> 当たり判定が起きた時に実行される </summary>
    private void OnCollisionEnter2D(Collision2D coll)
    {
        //if (collision.gameObject.TryGetComponent(out Player player)) { player.SpeedUp(_speedUpValue); Destroy(gameObject); }

        //衝突したオブジェクトが「Player」という名前のタグを持っているか判定
        if (coll.gameObject.tag == "Player")
        {
            //正しかった場合、Playerのデータを取得してくる
            //gameObject.GetComponent<ComponentName>(); で取得可能
            var playerComponent = coll.gameObject.GetComponent<Player>();
            playerComponent.SpeedUp(_speedUpValue);
        }
        Destroy(this.gameObject);
    }
}