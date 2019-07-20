using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatUpSC : MonoBehaviour {

    irairaboSC ira;
	// Use this for initialization
	void Start () {
        ira = GameObject.Find("irairabo").GetComponent<irairaboSC>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "irairabo" && irairaboSC.playing)
        {
            ira.BeatUp(0.2f);
        }
    }
}
