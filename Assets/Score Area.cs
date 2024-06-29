using UnityEngine;

public class PlayerScoreArea : MonoBehaviour
{
    ScoreManager scoreManager = null;      // スコア管理

    void Start()
    {
        // スコア管理オブジェクトを取得する
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    // ヒットしているとき毎フレーム呼び出される
    void OnTriggerStay2D(Collider2D other)
    {
        // 敵の弾にヒット
        if (other.gameObject.CompareTag("enemy_bullet"))
        {
            // スコアを加算
            if (scoreManager)
            {
                scoreManager.AddScore(1);
            }
        }
    }
}