using UnityEngine;
using UnityEngine.InputSystem;
public class InteractDebug : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnInteract(InputValue value)
    {
        Debug.Log("in interact");
        if (value.isPressed)
            Debug.Log("INTERACT pressed!");
        
    }
}
