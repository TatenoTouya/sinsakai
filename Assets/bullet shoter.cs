using UnityEngine;

public class Bulletshoter : MonoBehaviour
{
    public float _Bulletspeed = 10.0f; // 弾の速度
    public float BulletLifetime = 3.0f;
    public GameObject BulletObj; // 弾のプレハブ
    public float _ShootInterval = 0.2f; // 発射間隔（秒）

    private float _shootTimer = 0f; // 発射タイマー

    void Update()
    {
        // タイマーを更新
        _shootTimer += Time.deltaTime;

        // ボタンを押したときかつクールダウン時間を超えていたら発射
        if (Input.GetButtonDown("Fire1") && _shootTimer >= _ShootInterval)
        {
            ShootBullet();
            _shootTimer = 0f; // タイマーリセット
        }
    }

    // 弾を発射するメソッド
    private void ShootBullet()
    {
        Vector3 spawnPosition = transform.position + transform.right * 0.5f; // 少し前方に調整
        GameObject bulletInstance = Instantiate(BulletObj, spawnPosition, transform.rotation);
        Rigidbody2D bulletRigidbody = bulletInstance.GetComponent<Rigidbody2D>();
        if (bulletRigidbody != null)
        {
            bulletRigidbody.velocity = transform.right * _Bulletspeed; // ゲームオブジェクトの右方向に速度を設定
        }
        Destroy(bulletInstance, BulletLifetime);
    }

    // 弾の速度を上げるメソッド
    public void BulletSpeedUp(float value)
    {
        _Bulletspeed += value;
        Debug.Log($"BulletSpeedUp!! {_Bulletspeed}");
    }
    public void ShootIntervalfast(float value)
    {
        _ShootInterval += value;
        Debug.Log($"_ShootIntervalUp!! {_ShootInterval}");
    }
}
