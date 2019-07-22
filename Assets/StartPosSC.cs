using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosSC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "irairabo"){
            Debug.Log("start_in");
            irairaboSC.playing = true;
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
            other.gameObject.GetComponent<AudioSource>().mute = false;
            other.gameObject.GetComponent<AudioSource>().pitch = 1f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "irairabo")
        {
            irairaboSC.playing = true;
        }
    }
}
