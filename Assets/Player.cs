using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player thePlayer;
    
    public string myKeybind;
    //Player-prefab Keybind socket
    public string myName;
    //Name of player

    public delegate void getPlayerInfo(Player thePlayer);

    public event getPlayerInfo getPlayerInfoEvent;


    void WhatsMyName()
    {
        getPlayerInfoEvent?.Invoke(thePlayer);
    }
    
    
}
