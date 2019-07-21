using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutRangeSC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "irairabo"){
            irairaboSC.playing = false;
            other.gameObject.GetComponent<Renderer>().material.color = Color.gray;
            other.gameObject.GetComponent<AudioSource>().mute = true;
        }
    }
}
