using UnityEngine;
using System.Collections;

public class pauseWorld : MonoBehaviour {
	public static bool paused = false;
	public int ii = 0;
	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p")){
			paused = true;
			}

	}

	
	void OnGUI ()
	{
		if(paused == true){
		if (GUI.Button (new Rect (Screen.width*0.3f, Screen.height*0.33f, Screen.width*0.075f, Screen.height*0.055f), "Paused")) {
			paused = false;

		}
		}

	}


		


}

