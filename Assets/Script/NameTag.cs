using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTag : MonoBehaviour
{

    public Text NameCharacter;
    private void Start()
    {
        NameCharacter.text = DataPers.sharedInstance.username;
    }
}
