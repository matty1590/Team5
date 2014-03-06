using UnityEngine;
using System.Collections;

public class ThirdLowNegative : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		StatsCode.player2hunger =- (int) (StatsCode.player2hunger*0.10);
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}
