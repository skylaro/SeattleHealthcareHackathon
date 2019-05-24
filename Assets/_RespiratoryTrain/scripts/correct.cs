using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correct : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {

        AudioSource aud = GameObject.Find("narration").GetComponent<AudioSource>();
        
        if (!aud.isPlaying)
        {
            aud.clip = Resources.Load<AudioClip>("scenes/Start_Line_2_CORRECT_N95");
            aud.Play();
        }
    }
}
