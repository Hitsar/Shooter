using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _spawnPoint;

    private void Update()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bullet, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}
