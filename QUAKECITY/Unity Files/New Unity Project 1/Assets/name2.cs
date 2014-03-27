using UnityEngine;
using System.Collections;
using System.IO;


public class name2 : MonoBehaviour {
	public bool isAvailable = true;
	
	public string text = "";
	public static string textToShowWhenClicked2 = "";
	public string name22 = "";
	
	public string stringToEdit = "Input Character Name";
	void OnGUI() {
		
		// Check to see if this button
		// should be available
		if (isAvailable)
		{
			// Draw the button
			
			text = GUI.TextArea (new Rect (Screen.width*0.8f, Screen.height*0.1f, 100, 30), text);
			if( GUI.Button( new Rect(Screen.width*0.8f, Screen.height*0.12f, 100, 30 ), "OK" ))
				
			{
				// Disable Button After Click
				isAvailable = false;
				
				Debug.Log( text );
				textToShowWhenClicked2 = text;
				// Add code for any additional
				// behavior when the button is clicked
			}
		}
		
		
		name22 = textToShowWhenClicked2;
		
		
		//GUI.Label( new Rect(Screen.width*0.8f, Screen.height*0.1f, 200, 30 ), "" + textToShowWhenClicked2 );
	}
}



