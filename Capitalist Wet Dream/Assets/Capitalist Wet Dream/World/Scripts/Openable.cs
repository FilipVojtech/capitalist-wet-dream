using UnityEngine;

public class Openable : Interactable
{
    [SerializeField] private Animator animator;
    private bool _isDoorOpen;
    private static readonly int IsDoorOpen = Animator.StringToHash("isOpen");

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
        return _isDoorOpen
            ? $"Press {InGameUIController.interactionBind} to close"
            : $"Press {InGameUIController.interactionBind} to open";
    }
}