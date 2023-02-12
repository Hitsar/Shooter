using UnityEngine;

public class Bar : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullet bullet))
        {
            bullet.gameObject.SetActive(false);
        }
        if (collision.gameObject.TryGetComponent(out EnemyMove enemy))
        {
            enemy.gameObject.SetActive(false);
        }
    }
}
