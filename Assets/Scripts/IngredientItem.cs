using JetBrains.Annotations;
using UnityEngine;

public class IngredientItem : MonoBehaviour
{
    public Ingredient type;
    public IngredientStatus status;
    public SpriteRenderer sr;

    public IngredientItem(Ingredient type, IngredientStatus status)
    {
        this.type = type;
        this.status = status;
    }

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        RefreshVisual();
    }

    // private void OnValidate()
    // {
    //     // In editor, Awake might not have run yet, so we re-grab sr safely.
    //     sr = GetComponent<SpriteRenderer>();
    //     RefreshVisual();
    // }

    public void SetStatus(IngredientStatus newStatus)
    {
        status = newStatus;
        RefreshVisual();
    }

    private void RefreshVisual()
    {
        if(sr == null) return;
        if(type == null) return;

        sr.sprite = type.GetSprite(status);
    }

}
