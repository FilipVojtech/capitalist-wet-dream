using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 11f;
    private Vector2 _horizontalInput;

    [SerializeField] private float jumpHeight = 3.5f;
    private bool _jump;

    [SerializeField] private float gravity = -30f; // -9.8f
    private Vector3 _verticalVelocity = Vector3.zero;
    [SerializeField] private LayerMask groundMask;
    private bool _isGrounded;

    private void Update()
    {
        _isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
        if (_isGrounded) _verticalVelocity.y = 0;

        var horizontalVelocity =
            (transform.right * _horizontalInput.x + transform.forward * _horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        if (_jump && _isGrounded)
        {
            _verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
            _jump = false;
        }

        _verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(_verticalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 input)
    {
        _horizontalInput = input;
    }

    public void OnJumpPressed()
    {
        _jump = true;
    }
}