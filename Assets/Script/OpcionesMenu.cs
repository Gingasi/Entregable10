using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class OpcionesMenu : MonoBehaviour
{

    public AudioMixer audiomixer;
    private AudioSource Music;

    public AudioClip Sh1;
    public AudioClip Sh2;
    public TextMeshProUGUI[] Cancion;
    public GameObject[] Niveles;
    

    void Start()
    {
        Music = GetComponent<AudioSource>(); //Encuentra dentro del objeto el audiosource
    }
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("Volume", volume);  //Relaciona el slider volumen con nuestro audiomixer
    }

    public void Select1() //Para cualquier canción que se esté reproduciendo y reproduce Track1
    {
        Music.Stop();
        Music.PlayOneShot(Sh1, 1f);
    }
    public void Select2() //Para cualquier canción que se esté reproduciendo y reproduce Track2
    {
        Music.Stop();
        Music.PlayOneShot(Sh2, 1f);
    }

}
