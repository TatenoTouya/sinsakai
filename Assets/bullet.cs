using UnityEngine;

public class LazerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // 銃弾の速度

    void Update()
    {
        Move();
    }

    private void Move()
    {
        // 現在の位置に速度を加算して移動する
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
