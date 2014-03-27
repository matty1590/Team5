using UnityEngine;
using System.Collections;

public class donationBoothC : MonoBehaviour {
	public GameObject firstPlayer;
	public GameObject thirdPlayer;
	public bool range  = false;
	public float distance;	
	public float hSliderValue= 0;
	public float donationAmount= 0;
	public bool donation= false;

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
		}else{ hSliderValue= 0; range = false;}
	}


	void OnGUI () {

		if(range == true){
			GUI.Box (new Rect (Screen.width*0.192f, Screen.height*0.30f, Screen.width*0.155f, Screen.height*0.24f), "Donate Dollars");
			
			hSliderValue = (float)GUI.HorizontalSlider(new Rect (Screen.width*0.205f, Screen.height*0.40f, Screen.width*0.13f, Screen.height*0.05f), hSliderValue, 0, 500);	

			//GUI.Label(new Rect (Screen.width*0.2, Screen.height*0.43, Screen.width*0.13, Screen.height*0.1), "$"+hSliderValue.ToString());
			
			if (GUI.Button(new Rect(Screen.width*0.22f, Screen.height*0.43f, Screen.width*0.1f, Screen.height*0.08f),"Donate: $"+hSliderValue.ToString("f2"))){
				if(hSliderValue > 0)
				if(StatsCode.player1money >= hSliderValue){

					//hSliderValue = Mathf.Round(hSliderValue * 100f) / 100f;
					//int iValue = Mathf.FloorToInt(hSliderValue);
					StatsCode.player1money = StatsCode.player1money - hSliderValue;
					donationAmount = hSliderValue*0.05f;
					//int iValue2 = Mathf.FloorToInt(donationAmount);
					StatsCode.player2money+= donationAmount;
					donation = true;

				}
				
			}
			
		}

		if(donation == true){

			GUI.Box (new Rect (Screen.width*0.68f, Screen.height*0.30f, Screen.width*0.155f, Screen.height*0.24f), "Donation!"+"\n You earn $"+donationAmount.ToString("f2")+" in donations");
			if (GUI.Button(new Rect(Screen.width*0.705f, Screen.height*0.43f, Screen.width*0.1f, Screen.height*0.08f),"Close")){
				donation = false;
			}
		}
		
	}

}
