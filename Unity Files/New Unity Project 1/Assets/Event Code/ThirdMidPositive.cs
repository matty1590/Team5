using UnityEngine;
using System.Collections;

public class ThirdMidPositive : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		StatsCode.player2health += StatsCode.player2health;
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 4);
	}
}