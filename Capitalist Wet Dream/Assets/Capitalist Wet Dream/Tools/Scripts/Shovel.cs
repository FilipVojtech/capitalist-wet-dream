using UnityEngine;

public class Shovel : Tool
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject dirt;
    [field: SerializeField] public bool IsDirtVisible { get; private set; }
    private static readonly int Dig = Animator.StringToHash("Dig");
    private static readonly int Dump = Animator.StringToHash("Dump");

    private void Start()
    {
        IsDirtVisible = false;
        toolType = ToolType.Shovel;
    }

    private void Update()
    {
        dirt.SetActive(IsDirtVisible);
    }

    public void ShowDirt()
    {
        IsDirtVisible = true;
    }

    public void HideDirt()
    {
        IsDirtVisible = false;
    }

    public override void Use()
    {
        animator.SetTrigger(IsDirtVisible ? Dump : Dig);
    }
}