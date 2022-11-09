using UnityEngine;

[CreateAssetMenu(fileName = "New Attraction Config", menuName = "Configs/AttractionConfig")]

public class AttractionConfigs : ScriptableObject
{
    public string id;
    public string title;
    public string author;
    public string description;
    public string location;

    public Sprite image;

    public Vector2 thumnailSize;
    public Vector3 thumbnailImagePosition;
    public Vector2 headImageSize;
    public Vector3 headerImagePosition;


}
