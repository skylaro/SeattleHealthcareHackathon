using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p95 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        AudioSource aud = GameObject.Find("narration").GetComponent<AudioSource>();
        aud.clip = Resources.Load<AudioClip>("scenes/Start_Line_2_P95");
        if(!aud.isPlaying)
        aud.Play();
    }
}
