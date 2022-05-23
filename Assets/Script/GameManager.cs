using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI CurrentSong;
    public float CurrentVolume;
    public TextMeshProUGUI DificultadText;

    // Start is called before the first frame update
    void Start()
    {
        ApplyUserOptions();
    }

    public void ApplyUserOptions()
    {
        CurrentSong.text = PlayerPrefs.GetString("Cancion");
        CurrentVolume = PlayerPrefs.GetFloat("Volumen");
        DificultadText.text = PlayerPrefs.GetString("LevelDificultad");
    }

   
}
