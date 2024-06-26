using UnityEngine;

public class LazerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // e’e‚Ì‘¬“x

    void Update()
    {
        Move();
    }

    private void Move()
    {
        // Œ»İ‚ÌˆÊ’u‚É‘¬“x‚ğ‰ÁZ‚µ‚ÄˆÚ“®‚·‚é
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
