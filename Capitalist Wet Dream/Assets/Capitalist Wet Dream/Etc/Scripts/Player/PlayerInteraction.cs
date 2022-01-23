using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [Header("Interactions")] // 
    [SerializeField]
    private float interactionDistance;

    [SerializeField] private Camera cam;
    private bool _interacted;
    private Ray _ray;

    [field: Header("ActiveItem")] public Tool.ToolType ActiveTool { get; set; }

    [SerializeField] private float useToolDistance;
    [SerializeField] private GameObject shovel;
    private Shovel _shovelTool;
    [SerializeField] private GameObject goldPan;
    private GoldPan _goldPanTool;

    private void Start()
    {
        _interacted = false;
        _shovelTool = shovel.GetComponent<Shovel>();
        _goldPanTool = goldPan.GetComponentInChildren<GoldPan>();
        ActiveTool = Tool.ToolType.None;
    }

    private void Update()
    {
        HandleInteractions();
        HandleActiveItem();
    }

    private void HandleInteractions()
    {
        _ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));

        if (Physics.Raycast(_ray, out var hit, interactionDistance))
        {
            var interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                InGameUIController.SetActionDescription(interactable.GetDescription());

                if (_interacted) HandleInteraction(interactable);
            }
            else InGameUIController.SetActionDescription("");
        }
        else InGameUIController.SetActionDescription("");

        _interacted = false;
    }

    private void HandleActiveItem()
    {
        shovel.SetActive(ActiveTool == Tool.ToolType.Shovel);
        goldPan.SetActive(ActiveTool == Tool.ToolType.GoldPan);
    }

    public void Interact()
    {
        _interacted = true;
    }

    public void UseTool()
    {
        _ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));

        if (Physics.Raycast(_ray, out var hit, useToolDistance, LayerMask.GetMask("Item", "Default")))
        {
            if (ActiveTool == Tool.ToolType.Shovel)
            {
                if (hit.collider.CompareTag("Dig site"))
                {
                    _shovelTool.Use();
                }

                var panScript = hit.collider.GetComponentInChildren<GoldPan>();
                if (panScript != null && ToolState.HasShovelDirt)
                {
                    _shovelTool.Use();
                    panScript.FillDirt();
                }
            }
        }

        if (ActiveTool == Tool.ToolType.GoldPan)
        {
            _goldPanTool.Use();
        }
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