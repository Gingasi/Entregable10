using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence sharedInstance;

    public string SongSelected;
    public float VolumeValue;
    public int LevelDifficulty;

    private void Awake()
    {
        // Si la instancia no existe
        if (sharedInstance == null)
        {
            // Configuramos la instancia
            sharedInstance = this;
            // Nos aseguramos de que no sea destruida con el cambio de escena
            DontDestroyOnLoad(sharedInstance);
        }
        else
        {
            // Como ya existe una instancia, destruimos la copia
            Destroy(this);
        }
    }

    public void SaveForFutureGames()
    {
        PlayerPrefs.SetInt("LevelDificultad", LevelDifficulty);
        PlayerPrefs.SetFloat("Volumen", VolumeValue);
        PlayerPrefs.SetString("Cancion", SongSelected);
    }

}
