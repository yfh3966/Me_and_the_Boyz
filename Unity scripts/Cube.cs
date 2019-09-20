using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    PlayerLog eventLog;


    void Start()
    {
        eventLog = FindObjectOfType<PlayerLog>(); //gets the script PlayerLog
    }
    // add in to see textbox update**
    //private void Update()
    //{
    //eventLog.AddEvent("This updates every frame");
   // }

    void Dead() //this should be the method where the event a character dies
    {
        eventLog.AddEvent("A character has died");
    }

    void Movement()//this should be the method where the event a character moves
    {
        eventLog.AddEvent("A character has moved");
    }
}
