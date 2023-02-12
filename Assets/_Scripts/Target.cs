using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float _timeToDestroy;

    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;
        if (_time >= _timeToDestroy)
        {
            gameObject.SetActive(false);
            _time = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullet bullet))
        {
            Destroy(bullet.gameObject);
            gameObject.SetActive(false);
        }
    }
}
