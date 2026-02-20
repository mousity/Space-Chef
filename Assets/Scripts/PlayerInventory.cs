using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public IngredientItem heldIngredientId;

    // Check if the player already has an item
    public bool HasItem()
    {
        return heldIngredientId != null;
    }

    public bool tryPickup(IngredientItem ingredientId)
    {
        if(HasItem())
            return false;

        heldIngredientId = ingredientId;
        return true;
    }

    // Remove and return the held ingredient (used later for placing on counters)
    public IngredientItem Take()
    {
        IngredientItem temp = heldIngredientId;
        heldIngredientId = null;
        return temp;
    }

    // Add the ingredient given
    public IngredientItem HoldOrSwap(IngredientItem ingredient)
    {
        IngredientItem temp = heldIngredientId;
        heldIngredientId = ingredient;
        return temp;
    }
}
