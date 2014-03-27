using UnityEngine;
using System.Collections;

public class ReplayButton : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {


			if((StatsCode.player1health <1)&&(StatsCode.player2money <1 )){
			if (GUI.Button(new Rect(60, 140, 100, 60), "Restart"))
				StatsCode.player1health = 100;
			Application.LoadLevel(0);
			}
			if((StatsCode.minutes == 0)&&(StatsCode.seconds==0)){
			if (GUI.Button(new Rect(60, 140, 100, 60), "Restart"))
				StatsCode.player2health = 100;
			Application.LoadLevel(0);

		}
	}
}