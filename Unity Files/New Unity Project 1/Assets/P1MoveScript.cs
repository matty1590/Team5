using UnityEngine;
using System.Collections;

public class P1MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(pauseWorld.paused == false){
		// when Up Arrow is pressed, moves object forward 0.1 units per frame
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate (0,0,0.1f);
		}
		// When down arrow is pressed, moves object backwards 0.1 units per frame
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate (0,0,-0.1f);
		}
		//when left arrow is pressed, rotates object left 2 degrees per frame
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(0f,-2f,0f);
		}
		// when right arrow is pressed, rotates object right 2 degrees per frame
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(0f,2f,0f);
		}
	}
	}
}
