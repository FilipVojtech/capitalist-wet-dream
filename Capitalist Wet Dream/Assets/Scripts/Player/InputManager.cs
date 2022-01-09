using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Movement movement;
    [SerializeField] private MouseLook mouseLook;

    private Controls _controls;
    private Controls.GroundMovementActions _groundMovement;

    private Vector2 _horizontalInput;
    private Vector2 _mouseInput;

    private void Awake()
    {
        _controls = new Controls();
        _groundMovement = _controls.GroundMovement;

        // _groundMovement.[action].performed += context => do something
        _groundMovement.Horizontalmovement.performed += ctx => _horizontalInput = ctx.ReadValue<Vector2>();

        _groundMovement.Run.performed += ctx => movement.SetIsRunning(ctx.ReadValueAsButton());
        _groundMovement.Jump.performed += _ => movement.OnJumpPressed();

        _groundMovement.MouseX.performed += ctx => _mouseInput.x = ctx.ReadValue<float>();
        _groundMovement.MouseY.performed += ctx => _mouseInput.y = ctx.ReadValue<float>();
    }

    private void Update()
    {
        movement.ReceiveInput(_horizontalInput);
        mouseLook.ReceiveInput(_mouseInput);
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}