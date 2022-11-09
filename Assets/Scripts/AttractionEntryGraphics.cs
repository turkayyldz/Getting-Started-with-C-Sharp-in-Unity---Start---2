using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class AttractionEntryGraphics : MonoBehaviour
{

    public Image _thumbnail;
    public TMP_Text _attractionTitle;
    public TMP_Text _attractionLocation;

    public List<Image> stars;
    public Color _activeStarColor = new Color(1f, 0.74f, 0f);
    public Color _inactiveStarColor = new Color(0.78f, 0.78f, 0.78f);

    public AttractionScreenParameters _ScreenParametersPrefebs;
    private AttractionConfigs _attractionConfigs;



   public void OnClickAttraction()
    {
        var _paramaterObject = Instantiate(_ScreenParametersPrefebs);
        _paramaterObject._AttractionConfigs = _attractionConfigs;
        
        SceneManager.LoadScene("AttractionScreen", LoadSceneMode.Single);
    }

    public void Setup(AttractionConfigs configs)
    {
        _attractionConfigs = configs;
        _attractionTitle.text = _attractionConfigs.title;
        _attractionLocation.text = _attractionConfigs.location;

        SetupThumbnail();
        SetupStar(PlayerPrefs.GetInt(_attractionConfigs.id));
    }

    private void SetupThumbnail() 
    {
        _thumbnail.sprite = _attractionConfigs.image;
        var rectransform = _thumbnail.GetComponent<RectTransform>();
        rectransform.anchoredPosition3D = _attractionConfigs.thumbnailImagePosition;
        rectransform.sizeDelta = _attractionConfigs.thumnailSize;
    }

    private void SetupStar(int activeStarCount)
    {
        for (int i = 0; i < stars.Count; i++)
        {
            stars[i].color = i < activeStarCount ? _activeStarColor : _inactiveStarColor;
        }
    }
}
