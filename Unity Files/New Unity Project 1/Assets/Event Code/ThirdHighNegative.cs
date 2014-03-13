using UnityEngine;
using System.Collections;

public class ThirdHighNegative : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		StatsCode.player2health -= (int) (StatsCode.player2health*0.90);
		StatsCode.player2thirst -= (int) (StatsCode.player2thirst*0.30);
		StatsCode.player2hunger -= (int) (StatsCode.player2hunger*0.30);
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}
