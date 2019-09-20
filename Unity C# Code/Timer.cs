using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    //Initialise 2 minutes
    int countdownStartTime = 120;
    public Text timerUI;
    public Text roundUI;
    //Initialise rounds
    int initialRoundStart;



    // Start is called before the first frame update
    private void Start()
    {
        initialRoundStart = 1;

        CountDownTimer();
        RoundCountDown();
    }

    void CountDownTimer()
    {


        if (countdownStartTime > 0)
        {

            //Convert into timer text
            TimeSpan spanTime = TimeSpan.FromSeconds(countdownStartTime);
            //Convert seconds into minutes
            timerUI.text = spanTime.Minutes + " : " + spanTime.Seconds;
            //reduce the amount by one second
            countdownStartTime--;
            //This function will invoke after 1 second
            Invoke("CountDownTimer", 1.0f);

        }
        //if < 0
        else
        {
            timerUI.text = "Round Finished";
            //restart the scene when timer reach 0
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            //SceneManager.LoadScene(1);

        }



    }

    void RoundCountDown()
    {
        //roundUI.text = "Round: ";
        roundUI.text = "Round: " + initialRoundStart;
        initialRoundStart++;
        //Invoke("RoundCountDown", 5.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

