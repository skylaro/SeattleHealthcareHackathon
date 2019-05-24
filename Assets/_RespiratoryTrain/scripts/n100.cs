using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n100 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        AudioSource aud = GameObject.Find("narration").GetComponent<AudioSource>();
        aud.clip = Resources.Load<AudioClip>("scenes/Start_Line_2_N100");
        if (!aud.isPlaying)
            aud.Play();
    }
}
