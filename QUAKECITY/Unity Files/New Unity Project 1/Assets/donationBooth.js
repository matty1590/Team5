#pragma strict
var firstPlayer : GameObject;
var thirdPlayer  :GameObject;
var range : boolean = false;
var distance : float;	
var hSliderValue : int = 0;
function Start () {
firstPlayer = GameObject.Find("First_world_Camera");
thirdPlayer = GameObject.Find("Third_world_camera");
}

function Update () {
distance = Vector3.Distance(firstPlayer.transform.position, transform.position);

if(distance < 2)
		{
			range = true;
		}else{range = false;}
}

function OnGUI () {
	if(range == true){
			GUI.Box (new Rect (Screen.width*0.192, Screen.height*0.30, Screen.width*0.155, Screen.height*0.24), "Donate Dollars");
				
	hSliderValue = GUI.HorizontalSlider (Rect (Screen.width*0.205, Screen.height*0.40, Screen.width*0.13, Screen.height*0.1), hSliderValue, 0.0, 500.0);	
	//GUI.Label(new Rect (Screen.width*0.2, Screen.height*0.43, Screen.width*0.13, Screen.height*0.1), "$"+hSliderValue.ToString());
				
	if (GUI.Button(Rect(Screen.width*0.2, Screen.height*0.43, Screen.width*0.1, Screen.height*0.08),"Donate: $"+hSliderValue.ToString())){
	
	
	}

}

}