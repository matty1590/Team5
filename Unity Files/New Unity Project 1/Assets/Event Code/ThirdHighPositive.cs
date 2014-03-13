using UnityEngine;
using System.Collections;

public class ThirdHighPositive : MonoBehaviour {

	void Start () {
		
		StatsCode.player2hunger += (int) (StatsCode.player2hunger*0.50);
		StatsCode.player2thirst += (int) (StatsCode.player2thirst*0.60);
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}