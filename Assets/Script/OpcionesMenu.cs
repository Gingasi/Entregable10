using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;

public class OpcionesMenu : MonoBehaviour
{

    public AudioMixer audiomixer;
    private AudioSource Music;

    public AudioClip Sh1;
    public AudioClip Sh2;
    public TextMeshProUGUI[] Cancion;
    public GameObject[] Niveles;

    public Slider Volumeslider;
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;


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
