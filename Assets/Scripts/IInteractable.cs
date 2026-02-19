// Interface to define the common function in all interactable objects
// (like counters, cutting baords, dispensers, etc.)

public interface IInteractable
{
    public void Interact(PlayerInventory player);
}