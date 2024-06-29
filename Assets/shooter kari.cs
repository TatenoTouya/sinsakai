using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float Bulletspeed = 10.0f; // 弾の速度
    public float BulletLifetime = 3.0f;
    public GameObject BulletObj; // 弾のプレハブ

    private bool itemCollected = false; // アイテムが取得されたかどうかのフラグ

    // Update is called once per frame
    void Update()
    {
        // ボタンを押したとき
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet(); // 通常の弾を発射
        }

        // アイテムが取得された場合、少し下からもう一発の弾を発射する
        if (itemCollected)
        {
            ShootAdditionalBullet();
        }
    }

    // 通常の弾を発射するメソッド
    private void ShootBullet()
    {
        GameObject bulletInstance = Instantiate(BulletObj, transform.position, transform.rotation);
        Rigidbody2D bulletRigidbody = bulletInstance.GetComponent<Rigidbody2D>();
        if (bulletRigidbody != null)
        {
            bulletRigidbody.velocity = transform.right * Bulletspeed; // ゲームオブジェクトの右方向に速度を設定
        }
        Destroy(bulletInstance, BulletLifetime);
    }

    // 追加の弾を発射するメソッド
    private void ShootAdditionalBullet()
    {
        GameObject additionalBullet = Instantiate(BulletObj, transform.position - new Vector3(0f, 0.5f, 0f), transform.rotation);
        Rigidbody2D additionalBulletRigidbody = additionalBullet.GetComponent<Rigidbody2D>();
        if (additionalBulletRigidbody != null)
        {
            additionalBulletRigidbody.velocity = transform.right * Bulletspeed; // ゲームオブジェクトの右方向に速度を設定
        }
        Destroy(additionalBullet, BulletLifetime);
    }

    // アイテムが取得されたときに呼ばれるメソッド（外部から呼び出す想定）
    public void OnItemCollected()
    {
        itemCollected = true;
    }
}
