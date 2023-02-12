using UnityEngine;

public class Gun : BulletPull
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _spawnPoint;

    private void Start()
    {
        Initialized(_bullet);
    }
    private void Update()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);

        if (Input.GetMouseButtonDown(0))
        {
            if (TryGetObject(out GameObject bullet))
            {
                bullet.transform.position = _spawnPoint.position;
                bullet.transform.rotation = _spawnPoint.rotation;
                bullet.SetActive(true);
            }
        }
    }
}