using UnityEngine;

public class MiniPlayerController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;    // 弾のプレハブ
    [SerializeField] Vector3 offsetPos;          // プレイヤーからのオフセット位置
    GameObject player;                           // プレイヤーオブジェクト
    public float bulletSpeed = 10.0f;             // 弾の速度
    public float bulletLifetime = 3.0f;           // 弾の寿命

    void Start()
    {
        // プレイヤーオブジェクトを名前で検索して取得する
        player = GameObject.Find("player");
    }

    void Update()
    {
        // ボタンを押したときに弾を発射する
        if (Input.GetButtonDown("Fire1"))
        {
            // 現在のゲームオブジェクトの位置と向きで弾を生成する
            GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // 弾の速度を設定する
            Rigidbody2D bulletRigidbody = bulletInstance.GetComponent<Rigidbody2D>();
            if (bulletRigidbody != null)
            {
                bulletRigidbody.velocity = transform.right * bulletSpeed; // ゲームオブジェクトの右方向に速度を設定
            }

            // 弾の寿命を設定し、一定時間後に破棄する
            Destroy(bulletInstance, bulletLifetime);
        }
    }
    public void SetOffsetPos(Vector3 offset)
    {
        transform.localPosition = offset;
    }
}
