using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataPers : MonoBehaviour
{

    public static DataPers sharedInstance;
    public string username;


    public int colorSelected;
    public Color color;
    public int level;
    public string nameTag;

    public GameObject[] colors;
    public Text levelText;
    public Text usernames;

    private int _level;
    private int minLevel = 1;
    private int maxLevel = 10;

    private int _colorSelected;

    private void Awake()
    {

        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        ColorSelection();
    }

    public void SaveUserOptions()
    {
        

        DataPers.sharedInstance.colorSelected = _colorSelected;
        DataPers.sharedInstance.color = colors[_colorSelected].GetComponent<Image>().color;

        DataPers.sharedInstance.level = _level;

        DataPers.sharedInstance.username = usernames.text;

    }

    public void LoadUserOptions()
    {
       
        if (PlayerPrefs.HasKey("COLOR_SELECTED"))
        {
            _colorSelected = PlayerPrefs.GetInt("COLOR_SELECTED");

            _level = PlayerPrefs.GetInt("LEVEL");
            UpdateLevel();

            usernames.text = PlayerPrefs.GetString("USERNAME");
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

