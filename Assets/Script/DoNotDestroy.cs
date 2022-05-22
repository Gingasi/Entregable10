using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] Canciones = GameObject.FindGameObjectsWithTag("Song1");
            if(Canciones.Length > 1)
        {
            Destroy(this.gameObject);
        }
            DontDestroyOnLoad(this.gameObject);

        GameObject[] Cancion = GameObject.FindGameObjectsWithTag("Song2");
        if (Cancion.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
