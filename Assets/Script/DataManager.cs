using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public GameObject[] colors;
    public Text levelText;
    public Text username;

    private int _level;
    private int minLevel = 1;
    private int maxLevel = 10;

    private int _colorSelected;

    private void Start()
    {
        _level = int.Parse(levelText.text);
        LoadUserOptions();
    }

    private void Update()
    {
        ColorSelection();
    }

    public void SaveUserOptions()
    {
        #region PERSISTENCIA DE DATOS ENTRE ESCENAS

        DataPers.sharedInstance.colorSelected = _colorSelected;
        DataPers.sharedInstance.color = colors[_colorSelected].GetComponent<Image>().color;

        DataPers.sharedInstance.level = _level;

        DataPers.sharedInstance.username = username.text;
        #endregion

        #region PERSISTENCIA DE DATOS ENTRE PARTIDAS

        // DataPersistence.sharedInstance.SaveForFutureGames();

        Color color = colors[_colorSelected].GetComponent<Image>().color;
        PlayerPrefs.SetInt("COLOR_SELECTED", _colorSelected);
        PlayerPrefs.SetFloat("R", color[0]);
        PlayerPrefs.SetFloat("G", color[1]);
        PlayerPrefs.SetFloat("B", color[2]);

        // Nivel
        PlayerPrefs.SetInt("LEVEL", _level);

        // Nombre de usuario
        PlayerPrefs.SetString("USERNAME", username.text);
        #endregion
    }

    public void LoadUserOptions()
    {
        // Tal y como lo hemos configurado, si tiene esta clave, entonces tiene todas
        if (PlayerPrefs.HasKey("COLOR_SELECTED"))
        {
            _colorSelected = PlayerPrefs.GetInt("COLOR_SELECTED");

            _level = PlayerPrefs.GetInt("LEVEL");
            UpdateLevel();

            username.text = PlayerPrefs.GetString("USERNAME");
        }
    }

    private void UpdateLevel()
    {
        levelText.text = _level.ToString();
    }
 

    private void ColorSelection()
    {
        ChangeColorSelection();
    }

    private void ChangeColorSelection()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i].transform.GetChild(0).gameObject.SetActive(i == _colorSelected);
        }
    }
}