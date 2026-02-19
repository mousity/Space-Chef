using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public string heldIngredientId = "";

    // Check if the player already has an item
    public bool HasItem()
    {
        return heldIngredientId != "";
    }

    public bool tryPickup(string ingredientId)
    {
        if(HasItem())
            return false;

        heldIngredientId = ingredientId;
        return true;
    }

    // Remove and return the held ingredient (used later for placing on counters)
    public string Take()
    {
        string temp = heldIngredientId;
        heldIngredientId = "";
        return temp;
    }

    // Add the ingredient given
    public string HoldOrSwap(string ingredient)
    {
        string temp = heldIngredientId;
        heldIngredientId = ingredient;
        return temp;
    }
}
