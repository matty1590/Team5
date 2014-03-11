using UnityEngine;
using System.Collections;

public class scr_Pick_Up_2 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other){
		
		//GameObject.Find ("Gui Object").GetComponent<StatsCode>().player1hunger -= 10;
		//GameObject.Find ("Gui Object").GetComponent<StatsCode>();
		if (other.collider.name == "Pillbottle_Pickup(Clone)"){ 
			StatsCode.player2hunger += 10;
			Destroy (other.gameObject);}
		if (other.collider.name == "Money_Pickup(Clone)"){ 
			StatsCode.player2money += 50;
			Destroy (other.gameObject);}
		if (other.collider.name == "Sandwhich_Pickup(Clone)"){ 
			StatsCode.player2hunger += 10;
			Destroy (other.gameObject);}
		if (other.collider.name == "Water_Pickup(Clone)"){ 
			StatsCode.player2thirst += 20;
			Destroy (other.gameObject);}
	}
}
