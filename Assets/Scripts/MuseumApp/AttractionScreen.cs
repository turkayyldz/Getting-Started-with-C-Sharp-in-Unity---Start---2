using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;

namespace MuseumApp
{
    public class AttractionScreen : MonoBehaviour 
    {
        public Image _cover;
        public TMP_Text _attractionTitle;
        public TMP_Text _attractionLocation;
        public TMP_Text _attractionAuthor;
        public TMP_Text _attractionDescription;

        public List <Image> _star;
        public Color _activeStarColor = new Color(1f, 0.75f, 0f);
        public Color _inactiveStarColor = new Color(0.78f, 0.78f, 0.78f);

        private AttractionScreenParameters _attractionScreenParameters;

        private void Start()
        {
            _attractionScreenParameters = FindObjectOfType <AttractionScreenParameters>();
            var _attractionConfig = _attractionScreenParameters._AttractionConfigs;

            _attractionTitle.text = _attractionConfig.title;
            _attractionLocation.text = _attractionConfig.location;
            _attractionAuthor.text = _attractionConfig.author;
            _attractionDescription.text = _attractionConfig.description;

            SetupCover(_attractionConfig);

        }
        public void onClickStar(int _index)
        {
            PlayerPrefs.SetInt(_attractionScreenParameters._AttractionConfigs.id, _index);
            SetupStar(_index);
        }

        private void SetupStar(int _activeStarCount)
        {
            for (int i = 0; i < _star.Count; i++)
            {
                _star[i].color = i < _activeStarCount ? _activeStarColor : _inactiveStarColor;
            }
        }

        private void SetupCover(AttractionConfigs attractionConfigs) 
        {
            _cover.sprite = attractionConfigs.image;

            var recTransform = _cover.GetComponent<RectTransform>();
            recTransform.anchoredPosition3D = attractionConfigs.headerImagePosition;
            recTransform.sizeDelta = attractionConfigs.headImageSize;
        }


        public void OnClickBack() 
        {
            Destroy(_attractionScreenParameters.gameObject);

            SceneManager.LoadScene("HomeScreen", LoadSceneMode.Single);
            Debug.Log("Geri tuşu çalıştı");
            
        }
    }
}