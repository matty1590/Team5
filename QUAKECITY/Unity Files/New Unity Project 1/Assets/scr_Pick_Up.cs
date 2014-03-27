using UnityEngine;
using System.Collections;

public class scr_Pick_Up : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other){
		if (other.collider.name == "Pillbottle_Pickup(Clone)"){ 
			StatsCode.player1hunger += 10;
			audio.PlayOneShot(audio.clip, 1.0f);
			Destroy (other.gameObject);}
		if (other.collider.name == "Money_Pickup(Clone)"){ 
			StatsCode.player1money += 50;
			audio.PlayOneShot(audio.clip, 1.0f);
			Destroy (other.gameObject);}
		if (other.collider.name == "Sandwhich_Pickup(Clone)"){ 
			StatsCode.player1hunger += 10;
			audio.PlayOneShot(audio.clip, 1.0f);
			Destroy (other.gameObject);}
		if (other.collider.name == "Water_Pickup(Clone)"){ 
			StatsCode.player1thirst += 20;
			audio.PlayOneShot(audio.clip, 1.0f);
			Destroy (other.gameObject);
		}

	}
	void OnTriggerEnter(Collider other){

		//GameObject.Find ("Gui Object").GetComponent<StatsCode>().player1hunger -= 10;
	 //GameObject.Find ("Gui Object").GetComponent<StatsCode>();

	}
}
