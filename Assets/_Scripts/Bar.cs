using UnityEngine;

public class Bar : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullet bullet))
        {
            Destroy(bullet.gameObject);
        }
        if (collision.gameObject.TryGetComponent(out EnemyMove enemy))
        {
            enemy.gameObject.SetActive(false);
        }
    }
}
