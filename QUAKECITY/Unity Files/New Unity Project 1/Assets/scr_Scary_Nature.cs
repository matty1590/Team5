using UnityEngine;
using System.Collections;

public class scr_Scary_Nature : MonoBehaviour {
	public Camera cam;
	float shake = 0.0f;
	public float shakeAmount = 0.7f;
	public float decreaseAmount = 1.0f;
	Vector3 originalPos;
	bool Quake;
	float Chance;

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		Chance = Random.Range(0.0f,101.0f);

		if (Chance < 0.05f) {
			Quake = true;

				}

		if (Quake == true) {
			shake = 4.0f;
			Quake = false;
		//	originalPos = cam.transform.localPosition;

				}

		if (shake > 0) 
		{
			cam.transform.localPosition = new Vector3(cam.transform.localPosition.x + (Random.Range(-0.1f,0.1f) * shakeAmount),cam.transform.localPosition.y+(Random.Range(-0.01f,0.01f) * shakeAmount),cam.transform.localPosition.z +(Random.Range(-0.1f,0.1f) * shakeAmount));
			shake -= Time.deltaTime * decreaseAmount;
		}
		else
		{
			shake =0.0f;
			cam.transform.localPosition =new Vector3 (0.0f,0.0f,0.0f);
		}
	}

}
