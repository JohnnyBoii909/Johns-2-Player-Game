using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameplayManager : MonoBehaviour
{
    public Player player;

    public bool gameStarted = false;
    //Used to tell things if the game is over or not

    public string victorySpeech;
    //this gets accessed by the VictoryController script to print who the victor is
    
    public GameObject rules;
    //UI text element

    public List<Player> players;
    //these are used to disable the other UI elements when the game ends
    
    public delegate void TestEvent();

    public event TestEvent Test;

    public void OnEnable()
    {
        player.getPlayerInfoEvent += WhoWon;
    }

    public void OnDisable()
    {
        player.getPlayerInfoEvent -= WhoWon;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted == true)
        {
            if (Input.GetKeyDown(player.myKeybind))
            {
                WhoWon(player);
            }
        }
    }

    void WhoWon(Player player)
    //script just to run the code for when a player presses their key 
    {
            
            Debug.Log(player.myKeybind + " was pressed first");
            gameStarted = false;
            victorySpeech = player.myName + " is victorious";
            // DisableUIOnVictory();
            // return victorySpeech;
    }

    protected virtual void OnTest()
    {
        Test?.Invoke();
    }
}
