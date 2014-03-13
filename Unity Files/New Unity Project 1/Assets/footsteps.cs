using UnityEngine;
using System.Collections;

public class footsteps : MonoBehaviour {

void Update()
{
if(!audio.isPlaying && (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis("Vertical") != 0))
audio.Play ();
}
}