using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class TriggerInteractCaller : MonoBehaviour
{
    private IInteractable interactable;

    private PlayerController player;

    private void Awake()
    {
        interactable = GetComponentInParent<IInteractable>();
        // if(dispenser == null)
        // {
        //     dispenser = GetComponentInParent<DispenserStation>();
        // }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Current interactable is " + interactable);
        interactable = GetComponentInParent<IInteractable>();
        // Player must have playyerinventory
        Debug.Log("ENTER trigger: " + collision.name);
        player = collision.GetComponent<PlayerController>();
        player.currentTarget = interactable;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("EXIT trigger: " + collision.name);
        if (collision.GetComponent<PlayerController>() != null)
        {
            player = null;
        }
        interactable = null;
    }

    
}
