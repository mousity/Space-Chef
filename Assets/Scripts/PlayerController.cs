using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidBody;
    Vector2 input;
    Vector2 moveInput;

    public DispenserStation dispenserInRange;
    public CounterStation counterInRange;
    public PlayerInventory inventory;

    public IInteractable currentTarget;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }



    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        rigidBody.linearVelocity = moveInput.normalized * speed * Time.fixedDeltaTime;
    }

    public void OnInteract(InputValue value)
    {
        if (value.isPressed)
            Debug.Log("Interact pressed!");
        if (currentTarget != null)
        {
            Debug.Log("I see a " + currentTarget);
            currentTarget.Interact(inventory);
        }
    }
}
