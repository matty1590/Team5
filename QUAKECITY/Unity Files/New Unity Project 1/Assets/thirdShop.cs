using UnityEngine;
using System.Collections;

public class thirdShop : MonoBehaviour {

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
		//Debug.Log(distance);
		distance = Vector3.Distance(thirdPlayer.transform.position, transform.position);
		
		if(distance < 6)
		{
			range = true;
		}else{ range = false;}
	}
	
	void OnGUI () {
		if(range == true){
			GUI.Box (new Rect (Screen.width*0.592f, Screen.height*0.30f, Screen.width*0.18f, Screen.height*0.27f), "Buy Goods");
			GUI.Label  (new Rect (Screen.width*0.61f, Screen.height*0.385f, Screen.width*0.03f, Screen.height*0.03f), "$5.50");
			GUI.Label  (new Rect (Screen.width*0.67f, Screen.height*0.385f, Screen.width*0.03f, Screen.height*0.03f), "$7.10");
			if (GUI.Button (new Rect (Screen.width*0.594f, Screen.height*0.33f, Screen.width*0.055f, Screen.height*0.055f), water)) {
				if(StatsCode.player2money >= 5.50f)
				{
					if(StatsCode.player2thirst < 91){
						StatsCode.player2thirst+= 10;
						StatsCode.player2money -= 5.50f;
						
					}else{GUI.Label(new Rect (Screen.width*0.61f, Screen.height*0.3f, Screen.width*0.03f, Screen.height*0.03f), "Already Hydrated.");}
				}
			}
			
			if (GUI.Button (new Rect (Screen.width*0.655f, Screen.height*0.33f, Screen.width*0.055f, Screen.height*0.055f), food)) {
				
				if(StatsCode.player2money >= 1.50f)
				{
					if(StatsCode.player2hunger < 91){
						StatsCode.player2hunger+= 10;
						StatsCode.player2money -= 7.10f;
						
					}else{GUI.Label(new Rect (Screen.width*0.64f, Screen.height*0.3f, Screen.width*0.03f, Screen.height*0.03f), "Already Fed.");}
				}
			}
			
		}
	}
}
