using System;
using UnityEditor;
using UnityEngine;

public class CounterStation : MonoBehaviour, IInteractable
{
    public StationType stationType;
    public IngredientItem heldItem = null;
    [SerializeField] private SpriteRenderer objectRenderer;

    private void Awake()
    {
    }

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
            objectRenderer.sprite = heldItem.type.GetSprite(heldItem.status);
        } else
        {
            objectRenderer.sprite = null;
        }
    }
}
