using JetBrains.Annotations;
using UnityEngine;

public class IngredientItem : MonoBehaviour
{
    public Ingredient type;
    public IngredientStatus status;

    public IngredientItem(Ingredient type, IngredientStatus status)
    {
        this.type = type;
        this.status = status;
    }
}
