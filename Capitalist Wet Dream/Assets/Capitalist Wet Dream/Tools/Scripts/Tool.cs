using UnityEngine;

public abstract class Tool : MonoBehaviour
{
    [HideInInspector] public ToolType toolType;

    public enum ToolType
    {
        None,
        Shovel,
        GoldPan
    }

    public abstract void Use();
}