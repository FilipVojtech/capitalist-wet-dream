using System;
using UnityEngine;

public class ToolHolder : Interactable
{
    [SerializeField] private GameObject shovel;
    [SerializeField] private GameObject goldPan;
    [SerializeField] private Tool.ToolType initialToolType = Tool.ToolType.None;
    private Tool.ToolType _storedToolType;
    private PlayerInteraction _player;

    private void Start()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<PlayerInteraction>();
        _storedToolType = initialToolType;
    }

    private void Update()
    {
        shovel.SetActive(_storedToolType == Tool.ToolType.Shovel);
        goldPan.SetActive(_storedToolType == Tool.ToolType.GoldPan);
    }

    public override void Interact()
    {
        (_player.ActiveTool, _storedToolType) = (_storedToolType, _player.ActiveTool);
    }

    public override string GetDescription()
    {
        return _storedToolType == Tool.ToolType.None
            ? $"Press {InGameUIController.interactionBind} to place"
            : $"Press {InGameUIController.interactionBind} to take";
    }
}