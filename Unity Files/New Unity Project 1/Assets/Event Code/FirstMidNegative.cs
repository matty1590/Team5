using UnityEngine;
using System.Collections;

public class FirstMidNegative : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		StatsCode.player1money -= StatsCode.player1money*0.30f;
		StatsCode.player1health -= (int) (StatsCode.player1health*0.30);
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}

