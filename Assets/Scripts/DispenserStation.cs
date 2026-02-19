using UnityEngine;

public class DispenserStation : MonoBehaviour, IInteractable
{
    public StationType stationType;

    public void Interact(PlayerInventory player)
    {
        string ingredientId = stationType.dispensedIngredientId;

        bool success = player.tryPickup(ingredientId);

        if (success)
        {
            Debug.Log("Dispensed: " + ingredientId);
        } else
        {
            Debug.Log("Player inventory full");
        }
    }


}
