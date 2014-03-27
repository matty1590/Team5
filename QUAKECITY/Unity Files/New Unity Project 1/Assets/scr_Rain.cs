using UnityEngine;
using System.Collections;

public class scr_Rain : MonoBehaviour {
	float Rand;
		int i = 0;
	bool Raining;
	public GameObject Rain;
	// Use this for initialization
	void Start () {
		Rain.SetActive(false);
		Raining = false;
	}
	
	// Update is called once per frame
	void Update () {
		i++;
	if (i > 400){
			//RainCheck

			Rand = Random.Range (0,101);
			print (Rand);
			if (Rand > 70){
				if (Raining){
					Rain.SetActive(false);
					Raining = false;
				}
				else{
					Rain.SetActive(true);
					Rain.particleEmitter.minEmission = Random.Range(1000,2000);
					Rain.particleEmitter.maxEmission = Random.Range(1500,2500);
					Raining = true;
				}
			}
			i =0;
	}
}
}
