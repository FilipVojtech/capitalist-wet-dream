using UnityEngine;

public class ToolState : MonoBehaviour
{
    public static bool HasPanWater { get; set; }
    public static bool HasPanDirt { get; set; }
    public static bool HasPanGold { get; set; }
    public static bool HasShovelDirt { get; set; }

    private void Start()
    {
        HasPanDirt = false;
        HasPanWater = false;
        HasPanGold = false;
        HasShovelDirt = false;
    }
}