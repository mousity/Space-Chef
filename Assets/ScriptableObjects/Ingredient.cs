using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Scriptable Objects/Ingredient")]
public class Ingredient : ScriptableObject
{
    public string id;
    public string displayName;
    public Sprite rawSprite;
    public Sprite cookedSprite;
    public Sprite cutSprite;


}
