using UnityEngine;
using System.Collections;

public class shopFirst : MonoBehaviour {
	
	public GameObject firstPlayer;
	public GameObject thirdPlayer;
	public bool range  = false;
	public float distance;	

	public Texture water;
	public Texture food;
	// Use this for initialization
	void Start () {
		firstPlayer = GameObject.Find("First_world_Camera");
		thirdPlayer = GameObject.Find("Third_world_camera");
	
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(firstPlayer.transform.position, transform.position);
		
		if(distance < 2)
		{
			range = true;
		}else{ range = false;}
	}

	void OnGUI () {
		if(range == true){
			GUI.Box (new Rect (Screen.width*0.192f, Screen.height*0.30f, Screen.width*0.18f, Screen.height*0.27f), "Buy Goods");
			GUI.Label  (new Rect (Screen.width*0.21f, Screen.height*0.385f, Screen.width*0.03f, Screen.height*0.03f), "$1.50");
			GUI.Label  (new Rect (Screen.width*0.27f, Screen.height*0.385f, Screen.width*0.03f, Screen.height*0.03f), "$1.10");
			GUI.Label  (new Rect (Screen.width*0.21f, Screen.height*0.47f, Screen.width*0.03f, Screen.height*0.03f), "$1.00");
			GUI.Label  (new Rect (Screen.width*0.27f, Screen.height*0.47f, Screen.width*0.03f, Screen.height*0.03f), "$2.00");
			if (GUI.Button (new Rect (Screen.width*0.194f, Screen.height*0.33f, Screen.width*0.055f, Screen.height*0.055f), water)) {
				if(StatsCode.player1money >= 1.50f)
				{
					if(StatsCode.player1thirst < 91){
						StatsCode.player1thirst+= 10;
						StatsCode.player1money -= 1.50f;

					}else{GUI.Label(new Rect (Screen.width*0.21f, Screen.height*0.3f, Screen.width*0.03f, Screen.height*0.03f), "Already Hydrated.");}
				}
			}

			if (GUI.Button (new Rect (Screen.width*0.255f, Screen.height*0.33f, Screen.width*0.055f, Screen.height*0.055f), food)) {

				if(StatsCode.player1money >= 1.50f)
				{
					if(StatsCode.player1hunger < 91){
						StatsCode.player1hunger+= 10;
						StatsCode.player1money -= 1.10f;
						
					}else{GUI.Label(new Rect (Screen.width*0.24f, Screen.height*0.3f, Screen.width*0.03f, Screen.height*0.03f), "Already Fed.");}
				}
			}
			if (GUI.Button (new Rect (Screen.width*0.194f, Screen.height*0.41f, Screen.width*0.055f, Screen.height*0.055f), "Chocolate")) {

				if(StatsCode.player1money >= 1.00f)
				{
					if(StatsCode.player1hunger < 91){
						StatsCode.player1hunger+= 10;
						StatsCode.player1money -= 1.00f;
						
					}else{GUI.Label(new Rect (Screen.width*0.24f, Screen.height*0.3f, Screen.width*0.03f, Screen.height*0.03f), "Already Fed.");}
				}
			}
			if (GUI.Button (new Rect (Screen.width*0.255f, Screen.height*0.41f, Screen.width*0.075f, Screen.height*0.055f), "FairTrade Chocolate")) {

				if(StatsCode.player1money >= 1.00f)
				{
					if(StatsCode.player1hunger < 91){
						StatsCode.player1hunger+= 10;
						StatsCode.player1money -= 2.00f;
						StatsCode.player2money += 1.00f;
					
					}else{GUI.Label(new Rect (Screen.width*0.24f, Screen.height*0.3f, Screen.width*0.03f, Screen.height*0.03f), "Already Fed.");}
				}
			}
		}
	}
}



