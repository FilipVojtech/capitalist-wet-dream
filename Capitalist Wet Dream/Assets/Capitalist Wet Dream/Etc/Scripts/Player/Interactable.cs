using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public enum InteractionType
    {
        Click,
        Hold
    }

    [SerializeField] public InteractionType interactionType;

    public abstract void Interact();
    public abstract string GetDescription();
}