using UnityEngine;
using System.Collections;

public class FirstLowNegative : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		StatsCode.player1money =- StatsCode.player1money*0.10f;
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}
