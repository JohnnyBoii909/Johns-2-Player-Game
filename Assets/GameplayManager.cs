using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{

    public bool gameStarted = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted == true)
        {
            if (Input.GetKeyDown("s"))
            {
                Debug.Log("s was pressed first");
                Time.timeScale = 0;
                gameStarted = false;
            }

            if (Input.GetKeyDown("k"))
            {
                Debug.Log("k was pressed first");
                Time.timeScale = 0;
                gameStarted = false;
            }
        }
    }
}
