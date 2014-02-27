using UnityEngine;
using System.Collections;
using System;

public class CharacterNamer : MonoBehaviour {

	public TextMesh textmesh;
	public Texture2D Button;

	private string FirstPersonName = "Enter Name here";

	private string NonChangeableLabel = "Please name your first world character.... ";

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI ()
	{
		FirstPersonName = GUI.TextField (new Rect (25, 75, 250, 30), FirstPersonName, 100);


		GUI.Label (new Rect (25, 25, 250, 100), NonChangeableLabel);
	


		if (GUI.Button (new Rect (25, 120, 100, 20), "OK")) {
			textmesh.text = FirstPersonName;

		}

	}


}
