using UnityEditor;
using UnityEngine;

public class CounterStation : MonoBehaviour, IInteractable
{
    public StationType stationType;
    public string heldItem = "";

    public void Interact(PlayerInventory player)
    {
        if(player.heldIngredientId != "")
        {
            heldItem = player.Take();
        } else
        {
            heldItem = player.HoldOrSwap(heldItem);
        }
    }
}
