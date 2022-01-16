using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactionDistance;
    [SerializeField] private Camera cam;
    private bool _interacted;
    private Ray _ray;

    private void Start()
    {
        _interacted = false;
    }

    private void Update()
    {
        _ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        Debug.DrawRay(Camera.main.transform.position, _ray.direction);

        if (Physics.Raycast(_ray, out var hit, interactionDistance))
        {
            var interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                InGameUIController.SetActionDescription(interactable.GetDescription());

                if (_interacted)
                    HandleInteraction(interactable);
            }
        }
        else
            InGameUIController.SetActionDescription("");

        _interacted = false;
    }

    public void OnPress()
    {
        _interacted = true;
    }

    private void HandleInteraction(Interactable interactable)
    {
        switch (interactable.interactionType)
        {
            case Interactable.InteractionType.Click:
                interactable.Interact();
                break;
            case Interactable.InteractionType.Hold:
                break;
            default:
                Debug.LogError("Interaction type does not exist");
                break;
        }

        _interacted = false;
    }
}