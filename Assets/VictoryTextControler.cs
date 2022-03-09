using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VictoryTextControler : MonoBehaviour
{
    private TMP_Text _mTextComponent;

    public VictoryTextControler victoryTextControler;

    public delegate void disableUI(VictoryTextControler victoryTextControler);

    public event disableUI disableUIEvent;
    
    // Update is called once per frame
    void Update()
    {
        // if (gameplayManager.gameStarted == false)
        // {
        //     _mTextComponent = GetComponent<TMP_Text>();
        //     _mTextComponent.text = gameplayManager.victorySpeech;
        // }
    }
    
    void DisableUIOnVictory()
    {
        
        // rules.SetActive(false);
        // Player1.SetActive(false);
        // Player2.SetActive(false);
        // myKeybind.SetActive(false);
    }
}
