using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;
    public MeshRenderer player;
    public Text level;
    public Text username;

    void Start()
    {
        ApplyUserOptions();
    }


    public void ApplyUserOptions()
    {
        player.material.color = DataPers.sharedInstance.color;
        level.text = DataPers.sharedInstance.level.ToString();
        username.text = DataPers.sharedInstance.username;
    }
}
