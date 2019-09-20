using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLog : MonoBehaviour
{

    Text eventText;

    // adds an array to hold the action logs
    private List<string> Eventlog = new List<string>();

    string actionText = "";

    //limits the amount of lines in the box
    public int maxLines = 10;


    void Start()
    {
        //prints to the textbox
        eventText = GetComponent<Text>();
        eventText.text = actionText;
    }

    //When an event occurs then the line is sent to the GUI label
    public void AddEvent(string eventString)
    {
        Eventlog.Add(eventString);

        //when the log reaches 10 then it resets to 0
        if (Eventlog.Count >= maxLines)
        {
            Eventlog.RemoveAt(0);
        }

        eventText.text = actionText;

        //when an action log is made, then adds a new one on a new line
        foreach (string logEvent in Eventlog)
        {
            actionText += logEvent;
            actionText += "\n";
        }
    }
}
