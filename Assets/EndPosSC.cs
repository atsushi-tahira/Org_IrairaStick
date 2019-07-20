using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPosSC : MonoBehaviour {

    public GameObject clearText;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "irairabo" && irairaboSC.playing)
        {
            clearText.GetComponent<TextMesh>().text = "GameClear!!";
            clearText.SetActive(true);
            irairaboSC.playing = false;
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
            other.gameObject.GetComponent<AudioSource>().mute = true;
            GetComponent<AudioSource>().Play();
        }
    }
}
