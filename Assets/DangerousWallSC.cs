using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerousWallSC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "irairabo" && irairaboSC.playing)
        {
            Debug.Log("danerous_in");
            irairaboSC.playing = false;
            other.gameObject.GetComponent<Renderer>().material.color = Color.gray;
            other.gameObject.GetComponent<AudioSource>().mute = true;
            GameObject.Find("MissSE").GetComponent<AudioSource>().Play();
        }
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "irairabo")
    //    {
    //        irairaboSC.playing = false;
    //    }
    //}
}
