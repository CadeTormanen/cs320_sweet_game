using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buns : MonoBehaviour, Interaction
{
    public string interactionText { get; set; }
    [SerializeField]
    private Inventory playerInventory;
    [SerializeField]
    private string itemString;
    [SerializeField]
    private int numberOfItemsToGive;


    public bool Possible()
    {
        interactionText = "Take Hamburger\nBun";
        return true;
    }

    public void ExecuteInteraction()
    {
        playerInventory.Add(this.itemString, this.numberOfItemsToGive);
    }

    public void ValidateInteraction()
    {
        if (playerInventory == null) { Debug.LogError("Player Inventory Was Not Set In The Inspector"); }
    }
}
