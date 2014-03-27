using UnityEngine;
using System.Collections;

public class FirstHighNegative : MonoBehaviour {

	void Start () {
		
		StatsCode.player1money -= StatsCode.player1money*0.50f;
		StatsCode.player1health -= (int) (StatsCode.player1health*0.80);
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}
