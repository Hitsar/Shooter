using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;
    private float _moveInput;
    private bool _isGround;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _moveInput = Input.GetAxis("Horizontal");

        if (Input.GetButton("Horizontal"))
        {
            _rigidbody.velocity = new Vector2(_moveInput * _speed, _rigidbody.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W) && _isGround)
        {
            _isGround = false;
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            _isGround = true;
        }
    }
}