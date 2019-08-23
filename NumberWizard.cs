using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int minNum;
    int maxNum;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame(); 
    }

    void StartGame()
    {
        minNum = 1;
        maxNum = 1000;
        guess = 500;

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log($"The highest number you can pick is {maxNum}");
        Debug.Log($"The lowest number you can pick is {minNum}");
        Debug.Log($"Is your number higher or lower than {guess}");
        Debug.Log("Push up = Higher, Push Down = Lower, Enter = Correct");

        maxNum = maxNum + 1;    // Allow max number
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNum = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNum = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log($"Your number must be {guess}");
            StartGame();
        }        
    }

    void NextGuess()
    {
        guess = (maxNum + minNum) / 2;
        Debug.Log($"Is your number higher or lower than {guess}?");
        Debug.Log(guess);
    }
}
