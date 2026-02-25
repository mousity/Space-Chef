using UnityEngine;

public class TrashCan : MonoBehaviour, IInteractable
{
    public StationType stationType;

    public void Interact(PlayerInventory inventory)
    {
        if(inventory.heldIngredientId != null)
        {
            inventory.TrashItem();
        } else
        {
            Debug.Log("User not holding an item to trash!");
        }
    }


}
