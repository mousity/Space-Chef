using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Ingredient")]
public class Ingredient : ScriptableObject
{
    public string id;
    public string displayName;
    public Sprite rawSprite;
    public Sprite cookedSprite;
    public Sprite cutSprite;


    public Sprite GetSprite(IngredientStatus status)
    {
        switch (status)
        {
            case IngredientStatus.cut:
                return cutSprite != null ? cutSprite : rawSprite;
            case IngredientStatus.cooked:
                return cookedSprite != null ? cookedSprite : rawSprite;
            default:
                return rawSprite;
        }
    }
}
