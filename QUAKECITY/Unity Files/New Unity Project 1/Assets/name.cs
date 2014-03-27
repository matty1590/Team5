using UnityEngine;
using System.Collections;
using System.IO;


public class name : MonoBehaviour {
	public bool isAvailable = true;
	
	 public string text = "";
public string textToShowWhenClicked = "";
	public string name1 = "";
	
	public string stringToEdit = "Input Character Name";
	    void OnGUI() {
		
		 // Check to see if this button
// should be available
if (isAvailable)
{
// Draw the button
			
text = GUI.TextArea (new Rect (25, 25, 100, 30), text);
if( GUI.Button( new Rect(25, 100, 100, 30 ), "OK" ))
				
{
// Disable Button After Click
isAvailable = false;
				
 Debug.Log( text );
	textToShowWhenClicked = text;
// Add code for any additional
// behavior when the button is clicked
}
}


 

		name1 = textToShowWhenClicked;
		//GUI.Label( new Rect(Screen.width*0.4f, Screen.height*0.1f, 200, 30 ), "" + textToShowWhenClicked );
}
}
    


