using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownManager : MonoBehaviour
{
    public GameplayManager _gameplayManager;
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;

    void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    
    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisplay.text = "GO!";

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
        _gameplayManager.gameStarted = true;
    }
}