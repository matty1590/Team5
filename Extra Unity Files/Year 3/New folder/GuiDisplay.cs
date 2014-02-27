using UnityEngine;
using System.Collections;

public class GuiDisplay : MonoBehaviour {
	
	
	
	int xVal = 250; //the x coordinate of the timer
	int yVal = 0; //the y coordinate of the timer
	int hVal = 30; //the height of the timer box
	int wVal = 100; //the width of the timer box
	
	
	void OnGUI ()
	{
		GameObject timerCall = GameObject.Find("Gui Object");
		StatsCode tenMinuteTimer = timerCall.GetComponent<StatsCode>();
		
		StatsCode playerScript = tenMinuteTimer.GetComponent<StatsCode>();
		int timerMinutes = tenMinuteTimer.minutes;
		int timerSeconds = tenMinuteTimer.seconds;
		// get player stats from stats script:
		//player 1
		int player1Hunger = tenMinuteTimer.player1hunger;
		int player1Thirst = tenMinuteTimer.player1thirst;
		int player1Money = tenMinuteTimer.player1money;
		int player1Happiness = tenMinuteTimer.player1happiness;
		int player1Health = tenMinuteTimer.player1health;
		// player 2 
		int player2Hunger = tenMinuteTimer.player2hunger;
		int player2Thirst = tenMinuteTimer.player2thirst;
		int player2Money = tenMinuteTimer.player2money;
		int player2Happiness = tenMinuteTimer.player2happiness;
		int player2Health = tenMinuteTimer.player2health;

		// GUI Group for Timer
		GUI.BeginGroup( new Rect(Screen.width/2 , Screen.height/20, 500, 100));
		// Display Timer
		GUI.Box(new Rect(0,0, wVal, hVal), timerMinutes.ToString() + ":" + timerSeconds.ToString());
		// GUI.Box(new Rect(10, 10, 100, 90), "hello world"); //insert timer in ""
		GUI.EndGroup();

		//GUI Group for Player 1 Stats
		GUI.BeginGroup(new Rect(Screen.width/19 , Screen.height / 20, 500, 100));
		               GUI.Box ( new Rect (0,0,500, 30), "Hunger:" + player1Hunger.ToString () + "Thirst:" +  player1Thirst.ToString () + "Money:" +  player1Money.ToString () + "Happiness:" +  player1Happiness.ToString () + "Health:" +  player1Health.ToString ());
		GUI.EndGroup();
		// GUI group for Player 2 Stats
		GUI.BeginGroup(new Rect(Screen.width*0.6f, Screen.height/20, 500,100));
		GUI.Box ( new Rect (0,0,500, 30), "Hunger:" + player2Hunger.ToString () + "Thirst:" +  player2Thirst.ToString () + "Money:" +  player2Money.ToString () + "Happiness:" +  player2Happiness.ToString () + "Health:" +  player2Health.ToString ());
		GUI.EndGroup();
	}

}
