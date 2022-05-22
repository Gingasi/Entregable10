using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI Cancion;
    public TextMeshProUGUI Level;
    public static GameManager sharedInstance;

    // Start is called before the first frame update
    void Start()
    {
        ApplyUserOptions();
    }

    public void ApplyUserOptions()
    {
       
        
    }
}
