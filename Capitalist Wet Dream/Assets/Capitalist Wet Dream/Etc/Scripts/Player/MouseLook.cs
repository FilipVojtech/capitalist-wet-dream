using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float sensitivityX = 8f;
    [SerializeField] private float sensitivityY = 0.5f;
    private float _mouseX, _mouseY;

    [SerializeField] private Transform mainCamera;
    [SerializeField] private float xClamp = 85f;
    private float _xRotation;

    private void Update()
    {
        if (Cursor.lockState != CursorLockMode.Locked)
        {
            _mouseX = 0;
            _mouseY = 0;
        }

        transform.Rotate(Vector3.up, _mouseX * Time.deltaTime);

        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -xClamp, xClamp);
        var targetRotation = transform.eulerAngles;
        targetRotation.x = _xRotation;
        mainCamera.eulerAngles = targetRotation;
    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        _mouseX = mouseInput.x * sensitivityX;
        _mouseY = mouseInput.y * sensitivityY;
    }
}