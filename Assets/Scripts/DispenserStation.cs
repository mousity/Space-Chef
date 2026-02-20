using UnityEngine;

public class DispenserStation : MonoBehaviour, IInteractable
{
    public StationType stationType;

    public void Interact(PlayerInventory player)
    {
        IngredientItem ingredientId = stationType.dispensedIngredient;

        bool success = player.tryPickup(ingredientId);

        if (success)
        {
            Debug.Log("Dispensed: " + ingredientId.type.displayName);
        } else
        {
            Debug.Log("Player inventory full");
        }
    }


}
