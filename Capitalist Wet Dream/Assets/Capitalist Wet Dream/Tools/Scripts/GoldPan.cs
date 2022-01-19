using UnityEngine;

public class GoldPan : Tool
{
    [SerializeField] private Animator animator;
    private static readonly int Sieve = Animator.StringToHash("Sieve");
    private static readonly int Dump = Animator.StringToHash("Dump");

    public bool HasDirt { get; set; }
    [SerializeField] private GameObject dirt;
    public bool HasWater { get; set; }
    [SerializeField] private GameObject water;
    public bool HasGold { get; set; }
    [SerializeField] private GameObject gold;


    private void Start()
    {
        HasDirt = false;
        HasWater = false;
        HasGold = false;
    }

    private void Update()
    {
        if (transform.position.y < 99.7f)
        {
            FillWater();
        }
    }

    public override void Use()
    {
        animator.SetTrigger(Sieve);

        if (HasDirt && HasWater)
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
        HasDirt = true;
        dirt.SetActive(true);
    }

    public void EmptyDirt()
    {
        HasDirt = false;
        dirt.SetActive(false);
    }

    public void FillWater()
    {
        HasWater = true;
        water.SetActive(true);
    }

    public void EmptyWater()
    {
        HasWater = false;
        water.SetActive(false);
    }

    public void FillGold()
    {
        HasGold = true;
        gold.SetActive(true);
    }

    public void EmptyGold()
    {
        HasGold = false;
        gold.SetActive(false);
    }
}