using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int bulletSpeed = 10;
    public int scoreValue = 100;

    // Update is called once per frame
    void Update()
    {
        Move();
        Delete();
    }

    private void Move()
    {
        transform.position += new Vector3(bulletSpeed, 0, 0) * Time.deltaTime;
    }

    // ‰æ–ÊŠO‚Éo‚½‚çÁ‚·
    private void Delete()
    {
        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue);
            }
        }
    }
}
