using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TextControlScript : MonoBehaviour
{
    public GameplayManager gameplayManager;
    public TextMeshProUGUI textMeshProUGUI;

    private TMP_Text _mTextComponent;

    private void OnEnable()
    {
        
    }

    private void Awake()
    {
        // Get a reference to the text component.
        // Since we are using the base class type <TMP_Text> this component could be either a <TextMeshPro> or <TextMeshProUGUI> component.
        _mTextComponent = GetComponent<TMP_Text>();
 
       
        _mTextComponent.text = ("Player 1's key is " + gameplayManager.GetComponent<GameplayManager>());

    }
}
