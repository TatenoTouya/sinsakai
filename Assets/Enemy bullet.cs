using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private int bulletSpeed = 8;

    void Update()
    {
        Move();
        Delete();
    }

    private void Move()
    {
        transform.position += new Vector3(-bulletSpeed, 0, 0) * Time.deltaTime;

    }

    //âÊñ äOÇ…èoÇΩÇÁè¡Ç∑
    private void Delete()
    {
        if (this.transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}