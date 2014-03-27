using UnityEngine;
using System.Collections;

public class P2MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(pauseWorld.paused == false){
		// when W key is pressed, moves object forward 0.1 units per frame
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate (0,0,0.1f);
		}
		// when S key is pressed, moves object backwards 0.1 units per frame
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate (0,0,-0.1f);
		}
		// when A key is pressed, rotates object 2 degrees left per frame
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(0f,-2f,0f);
		}
		// when D key is pressed, rotates object 2 degrees right per frame
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0f,2f,0f);
		}
		}
	}


}
