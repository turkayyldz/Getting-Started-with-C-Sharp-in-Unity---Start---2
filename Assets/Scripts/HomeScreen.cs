using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeScreen : MonoBehaviour
{
    public GameObject _loginButton;
    public TMP_Text _username;
    public RectTransform _attractionEnteriesParent;
    public AttractionEntryGraphics _attractionPrefebs;
    //public AttractionConfigs _attraction;
    public List<AttractionConfigs> attractions;

    public void Awake()
    {
        //var _newAttraction = Instantiate(_attractionPrefebs, _attractionEnteriesParent);
        foreach (var attractions in attractions)
        {
            var _newAttraction = Instantiate(_attractionPrefebs, _attractionEnteriesParent);

            _newAttraction.Setup(attractions);
        }
        SetupUsarName();
    }

    public void SignUp()
    {
        SceneManager.LoadScene("SignupPopup",LoadSceneMode.Additive);
    }
    public void SetupUsarName()
    {
        if (!PlayerPrefs.HasKey(PlayerData.PlayerDataSaveKey))
        {
            _loginButton.SetActive(true);
            _username.gameObject.SetActive(false);
            return;
        }
        var playerData = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString(PlayerData.PlayerDataSaveKey));
        _loginButton.SetActive(false);
        _username.gameObject.SetActive(true);
        _username.text = playerData.username;


    }

}
