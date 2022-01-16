using UnityEngine;
using UnityEngine.InputSystem;

public class Openable : Interactable
{
    [SerializeField] private Animator animator;

    [Header("DEBUG")]
    /*[SerializeField]*/ private bool _isDoorOpen;

    private static readonly int IsDoorOpen = Animator.StringToHash("isOpen");

    [SerializeField] private InputActionReference interactAction;

    private void Start()
    {
        _isDoorOpen = false;
    }

    private void Update()
    {
        animator.SetBool(IsDoorOpen, _isDoorOpen);
    }

    public override void Interact()
    {
        _isDoorOpen = !_isDoorOpen;
    }

    public override string GetDescription()
    {
        // Get keybinding
        var bindIndex = interactAction.action.GetBindingIndexForControl(interactAction.action.controls[0]);
        var binding = InputControlPath.ToHumanReadableString(
            interactAction.action.bindings[bindIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice
        );

        return _isDoorOpen ? $"Press {binding} to close" : $"Press {binding} to open";
    }
}