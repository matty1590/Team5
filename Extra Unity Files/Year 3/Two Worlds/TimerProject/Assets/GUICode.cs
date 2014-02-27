using UnityEngine;
using System.Collections;

public class GUICode : MonoBehaviour {


    
    int xVal = 50; //the x coordinate of the timer
    int yVal = 0; //the y coordinate of the timer
    int hVal = 30; //the height of the timer box
    int wVal = 100; //the width of the timer box
    

    void OnGUI ()
    {
        GameObject timerCall = GameObject.Find("scriptObject");
        TenMinuteTimer tenMinuteTimer = timerCall.GetComponent<TenMinuteTimer>();

        TenMinuteTimer playerScript = tenMinuteTimer.GetComponent<TenMinuteTimer>();
        int timerMinutes = tenMinuteTimer.minutes;
        int timerSeconds = tenMinuteTimer.seconds;
        
        GUI.Box(new Rect(xVal, yVal, wVal, hVal), timerMinutes.ToString() + ":" + timerSeconds.ToString());
        // GUI.Box(new Rect(10, 10, 100, 90), "hello world"); //insert timer in "" 
    }
}
