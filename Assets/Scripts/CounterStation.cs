using System;
using UnityEditor;
using UnityEngine;

public class CounterStation : MonoBehaviour, IInteractable
{
    public StationType stationType;
    public IngredientItem heldItem = null;
    [SerializeField] private SpriteRenderer objectRenderer;
    
    [SerializeField] private CounterFacing facing;
    [SerializeField]private Sprite northSprite;
    [SerializeField]private Sprite southSprite;
    [SerializeField]private Sprite eastSprite;
    [SerializeField]private Sprite westSprite;
    

    public void Interact(PlayerInventory player)
    {
        if(player.heldIngredientId != null)
        {
            heldItem = player.Take();
        } else
        {
            heldItem = player.HoldOrSwap(heldItem);
        }

        if(heldItem)
        {
            objectRenderer.sprite = heldItem.GetCurrentSprite();
        } else
        {
            objectRenderer.sprite = null;
        }
    }
}
