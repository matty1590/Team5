using UnityEngine;
using System.Collections;

public class FirstHighPositive : MonoBehaviour {

	void Start () {
		
		StatsCode.player1money += StatsCode.player1money*2;
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}
