using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irairaboSC : MonoBehaviour {

    public static bool playing = false;
    //float pitch;
	// Use this for initialization
	void Start () {
        //pitch = GetComponent<AudioSource>().pitch;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        }

    }

    public void BeatUp(float temp)
    {
        GetComponent<AudioSource>().pitch += temp;
    }
}
