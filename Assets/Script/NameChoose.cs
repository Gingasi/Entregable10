using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameChoose : MonoBehaviour
{
    public string username;

    public Text NameCharacter;

    public void SaveUserName()
    {
        string _username = NameCharacter.text;

        DataPers.sharedInstance.username = _username;
    }
}
