using UnityEngine;
using System.Collections;

public class TenMinuteTimer : MonoBehaviour
{
    int counter = 0;
    public int seconds = 0;
    public int minutes = 10;

    bool timerEnd = false;

    void Start() { } // Use this for initialization

    void Update() // Update is called once per frame
    {
        counter++;
        if (timerEnd == false)
        {
            if (minutes <= 0 && seconds <= 0)
            {
                timerEnd = true;
            }

            if (seconds <= 0)
            {
                minutes--; //add one to minutes
                seconds = 59; //reset seconds to 0
            }

            if (counter >= 60) //replace '60' with number of ticks per second 
            {
                seconds--; //add one to seconds
                counter = 0; //reset counter to 0
            }
        }

        if (timerEnd == true)
        {
            //do the thing
        }
	}
}
