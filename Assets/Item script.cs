using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float moveSpeed = 3f; // アイテムの移動速度

    // Update is called once per frame
    void Update()
    {
        MoveLeft(); // 左に移動するメソッドを呼び出す
    }

    // 左に移動するメソッド
    private void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    // プレイヤーに当たったときに呼ばれるメソッド
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // プレイヤーに当たったら、Bullets スクリプトを持つオブジェクトを取得する
            Bullets bulletsScript = collision.gameObject.GetComponent<Bullets>();
            if (bulletsScript != null)
            {
                bulletsScript.OnItemCollected(); // Bullets スクリプト内のフラグを true にするメソッドを呼び出す
            }

            // アイテム自体を破棄する（任意）
            Destroy(gameObject);
        }
    }
}
