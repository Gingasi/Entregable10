using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public void NewGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Pase a la siguiente escena. 


    }
    public void Credits()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); //Pase a 2 escenas siguiente. 


    }

    public void QuitGame() //Abandona el juego. 
    { 
        Application.Quit();
        Debug.Log("QuitGame");
    }

}



