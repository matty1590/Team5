using UnityEngine;
using System.Collections;

public class scr_Time : MonoBehaviour {
	public int Time;
	public bool Day;
	int Once;
	float myRot;
	float SunTimer = 2.5f;
	int HourTimer = 300;
	int DayTimer = 3600;

	// Use this for initialization
	void Start () {
		myRot = 0.125f;
		Once = 1;

	}
	
	// Update is called once per frame
	void Update () {

		DayTimer--;
		SunTimer --;
		HourTimer --;
		if (DayTimer <= 0) {
			print("1minutes have passed");

			DayTimer = 3600;
				}
		if (SunTimer <= -0.5f) {
			SunTimer = 2.5f;

			transform.Rotate(myRot,0,0,Space.Self);
				}
		if (HourTimer <= 0) {
			HourTimer = 300;	
			if(Time <=11){
			Time ++;
			}
			else{
				Once = 1;
				Time = 1;
			}

				}
		if (Time == 12) {
						if (Once == 1) {
								Once = 0;
								if (Day != false) {
										Day = false;
								} else {
										Day = true;
								}

						}
				}
	}


}
