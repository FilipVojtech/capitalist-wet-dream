using UnityEngine;

public class Shovel : Tool
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject dirt;
    private static readonly int Dig = Animator.StringToHash("Dig");
    private static readonly int Dump = Animator.StringToHash("Dump");

    private void Start()
    {
        ToolState.HasShovelDirt = false;
        toolType = ToolType.Shovel;
    }

    private void Update()
    {
        dirt.SetActive(ToolState.HasShovelDirt);
    }

    public void ShowDirt()
    {
        ToolState.HasShovelDirt = true;
    }

    public void HideDirt()
    {
        ToolState.HasShovelDirt = false;
    }

    public override void Use()
    {
        animator.SetTrigger(ToolState.HasShovelDirt ? Dump : Dig);
    }
}