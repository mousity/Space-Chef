using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public IngredientItem heldIngredientId;
    private SpriteRenderer sr;

    public void Awake()
    {
        sr = transform.Find("HeldItemVisual").GetComponent<SpriteRenderer>();
    }

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
        sr.sprite = heldIngredientId.type.GetSprite(heldIngredientId.status);
        return true;
    }

    // Remove and return the held ingredient (used later for placing on counters)
    public IngredientItem Take()
    {
        IngredientItem temp = heldIngredientId;
        heldIngredientId = null;
        DisableItemSprite();
        return temp;
    }

    // Add the ingredient given
    public IngredientItem HoldOrSwap(IngredientItem ingredient)
    {
        IngredientItem temp = heldIngredientId;
        heldIngredientId = ingredient;
        EnableItemSprite(heldIngredientId.type.GetSprite(heldIngredientId.status));
        return temp;
    }

    public void TrashItem()
    {
        heldIngredientId = null;
        DisableItemSprite();
    }

    public void DisableItemSprite()
    {
        sr.sprite = null;
    }

    public void EnableItemSprite(Sprite sp){
        sr.sprite = sp;
    }
}
