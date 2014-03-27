using UnityEngine;
using System.Collections;
using System.IO;

public class TiggerSound : MonoBehaviour {



    void OnTriggerEnter(Collider coll)
    {
    if(coll.gameObject.tag == "Player")
    audio.PlayOneShot(audio.clip, 1.0f);
    }
}