using UnityEngine;

public class TrashCan : MonoBehaviour, IInteractable
{
    public StationType stationType;
    private SpriteRenderer sr;


    public void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = stationType.sprite;
    }
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
