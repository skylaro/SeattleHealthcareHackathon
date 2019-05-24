using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeline : MonoBehaviour {
	// Use this for initialization
	void Start () {
        //play welcome message
        AudioSource aud = GetComponent<AudioSource>();
        aud.clip = Resources.Load<AudioClip>("scenes/Start_Line_1");
        aud.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
