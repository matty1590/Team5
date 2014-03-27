using UnityEngine;
using System.Collections;

public class FirstMidPositive : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		StatsCode.player1hunger += StatsCode.player1hunger;
		StatsCode.player1health -= (int) (StatsCode.player1health*0.10);
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}

