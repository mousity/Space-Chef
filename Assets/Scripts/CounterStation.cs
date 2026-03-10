using UnityEditor;
using UnityEngine;

public class CounterStation : MonoBehaviour, IInteractable
{
    public StationType stationType;
    public IngredientItem heldItem = null;

    public void Interact(PlayerInventory player)
    {
        if(player.heldIngredientId != null)
        {
            heldItem = player.Take();
        } else
        {
            heldItem = player.HoldOrSwap(heldItem);
        }
    }
}
