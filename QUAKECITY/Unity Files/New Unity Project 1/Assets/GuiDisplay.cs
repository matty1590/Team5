using UnityEngine;
using System.Collections;

public class GuiDisplay : MonoBehaviour {
	
	GameObject Time2;
	GameObject Time1;
	bool DayTime1;
	bool DayTime2;
	
	int xVal = 250; //the x coordinate of the timer
	int yVal = 0; //the y coordinate of the timer
	int hVal = 30; //the height of the timer box
	int wVal = 100; //the width of the timer box
	
	private string FPName ="bob";
	private string namefirst= "";
	private string namesecond = "";

	void Start(){
		Time1 = GameObject.Find("First_World_Light");
		Time2 = GameObject.Find("Third_World_Light");
		}
	void Update(){
		DayTime1 = Time1.GetComponent<scr_Time> ().Day;
		DayTime2 = Time2.GetComponent<scr_Time> ().Day;
		}

	void OnGUI ()
	{
				GameObject timerCall = GameObject.Find ("Gui Object");
				StatsCode tenMinuteTimer = timerCall.GetComponent<StatsCode> ();
				StatsCode playerScript = tenMinuteTimer.GetComponent<StatsCode> ();
				CharacterNamer namer = tenMinuteTimer.GetComponent<CharacterNamer> ();
				FPName = namer.FirstPersonName;
		namefirst = timerCall.GetComponent<name>().name1;
		namesecond = timerCall.GetComponent<name2>().name22;
				//SPName = ^
//				int timerMinutes = tenMinuteTimer.minutes;
//				int timerSeconds = tenMinuteTimer.seconds;
				// get player stats from stats script:
				//player 1
				//	int player1Hunger = tenMinuteTimer.player1hunger;
				//	int player1Thirst = tenMinuteTimer.player1thirst;
				//int player1Money = tenMinuteTimer.player1money;
				//		int player1Happiness = tenMinuteTimer.player1happiness;
				//int player1Health = tenMinuteTimer.player1health;
				// player 2 
				//	int player2Hunger = tenMinuteTimer.player2hunger;
				//	int player2Thirst = tenMinuteTimer.player2thirst;
				//		int player2Money = tenMinuteTimer.player2money;
				//	int player2Happiness = tenMinuteTimer.player2happiness;
				//	int player2Health = tenMinuteTimer.player2health;
		
				// GUI Group for Timer
				GUI.BeginGroup (new Rect (Screen.width / 2, Screen.height / 20, 500, 100));
				// Display Timer
		GUI.Box (new Rect (0, 0, wVal, hVal), StatsCode.minutes.ToString () + ":" + StatsCode.seconds.ToString ());
				// GUI.Box(new Rect(10, 10, 100, 90), "hello world"); //insert timer in ""
				GUI.EndGroup ();
		
				//GUI Group for Player 1 Stats
				if (StatsCode.player1health > 0) {
						GUI.BeginGroup (new Rect (Screen.width / 19, Screen.height / 20, 500, 100));
						GUI.Box (new Rect (0, 0, 500, 30), namefirst + " Hunger: " + StatsCode.player1hunger.ToString () + " Thirst: " + StatsCode.player1thirst.ToString () + " Money: $" + StatsCode.player1money.ToString ("f2") + " Happiness: " + StatsCode.player1happiness.ToString () + " Health: " + StatsCode.player1health.ToString ());
						GUI.EndGroup ();
				}
				// GUI group for Player 2 Stats
				if (StatsCode.player2health > 0) {
						GUI.BeginGroup (new Rect (Screen.width * 0.6f, Screen.height / 20, 500, 100));
			GUI.Box (new Rect (0, 0, 500, 30),namesecond+" Hunger: " + StatsCode.player2hunger.ToString () + " Thirst: " + StatsCode.player2thirst.ToString () + " Money: $" + StatsCode.player2money.ToString ("f2") + " Happiness: " + StatsCode.player2happiness.ToString () + " Health: " + StatsCode.player2health.ToString ());
						GUI.EndGroup ();
				}

				if (StatsCode.player1health < 0)
						GUI.TextArea (new Rect (Screen.width / 19, Screen.height / 15, 500, 100), "You have died!");
				if (StatsCode.player2health < 0)
						GUI.TextArea (new Rect (Screen.width * 0.6f, Screen.height / 15, 500, 100), "You have died!");
				if (StatsCode.timerEnd == true) {
						Destroy (GameObject.Find ("Third_world_camera"));
						Destroy (GameObject.Find ("First_world_Camera"));
						GUI.TextArea (new Rect (Screen.width / 2, Screen.height / 15, 500, 100), "Congratulations you survived");
				}



		if (DayTime1 == true) {
						GUI.TextArea (new Rect (Screen.width / 20, Screen.height - 50, 40, 25), "" + Time1.GetComponent<scr_Time> ().Time + "AM");
				} else {
						GUI.TextArea (new Rect (Screen.width / 20, Screen.height - 50, 40, 25), "" + Time1.GetComponent<scr_Time> ().Time + "PM");
				}

		if (DayTime2 == true) {
						GUI.TextArea (new Rect (Screen.width *0.6f, Screen.height - 50, 40, 25), "" + Time2.GetComponent<scr_Time> ().Time + "AM");
				} else {
						GUI.TextArea (new Rect (Screen.width*0.6f, Screen.height - 50, 40, 25), "" + Time2.GetComponent<scr_Time> ().Time + "PM");
				}
		}

}		
