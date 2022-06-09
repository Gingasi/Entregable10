using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneFlow : MonoBehaviour
{
    public void Next1()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Pase a la siguiente escena. 

    }

    public void Next2()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  

    }
    public void Next3()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 

    }
    public void Next4()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    public void BackOne()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }
}