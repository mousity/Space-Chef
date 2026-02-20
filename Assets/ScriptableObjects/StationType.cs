using UnityEngine;

[CreateAssetMenu(fileName = "StationType", menuName = "Scriptable Objects/StationType")]
public class StationType : ScriptableObject
{

    // Normal fields for scriptable station object
    public string id;   
    public string displayName;
    public Sprite sprite;

    // References an enum menu for the station type
    public StationKind stationKind;

    // Used only if it's an ingredient dispenser
    public IngredientItem dispensedIngredient;

    // Only for cutting boards
    public float cutTime = 0.8f;

}
