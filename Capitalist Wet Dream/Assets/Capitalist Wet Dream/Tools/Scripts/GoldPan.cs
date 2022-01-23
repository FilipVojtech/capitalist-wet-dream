using UnityEngine;

public class GoldPan : Tool
{
    [SerializeField] private Animator animator;
    private static readonly int Sieve = Animator.StringToHash("Sieve");
    private static readonly int Dump = Animator.StringToHash("Dump");

    [SerializeField] private GameObject dirt;
    [SerializeField] private GameObject water;
    [SerializeField] private GameObject gold;

    private void Update()
    {
        if (transform.position.y < 99.7f)
        {
            FillWater();
        }

        dirt.SetActive(ToolState.HasPanDirt);
        water.SetActive(ToolState.HasPanWater);
        gold.SetActive(ToolState.HasPanGold);
    }

    public override void Use()
    {
        animator.SetTrigger(Sieve);

        if (ToolState.HasPanDirt && ToolState.HasPanWater)
        {
            EmptyDirt();
            EmptyWater();
            FillGold();
        }
        else
        {
            EmptyDirt();
            EmptyWater();
            EmptyGold();
        }
    }

    public void FillDirt()
    {
        ToolState.HasPanDirt = true;
    }

    public void EmptyDirt()
    {
        ToolState.HasPanDirt = false;
    }

    public void FillWater()
    {
        ToolState.HasPanWater = true;
    }

    public void EmptyWater()
    {
        ToolState.HasPanWater = false;
    }

    public void FillGold()
    {
        ToolState.HasPanGold = true;
    }

    public void EmptyGold()
    {
        ToolState.HasPanGold = false;
    }
}