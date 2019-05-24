using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioQueue {
    private static AudioSource aud = GameObject.Find("narration").GetComponent<AudioSource>();
    private static Queue<AudioClip> q;

    public static void enqueue(AudioClip c)
    {
        q.Enqueue(c);
    }
	
	// Update is called once per frame
	public static void Update () {
        if (!aud.isPlaying && q.Count != 0)
        {
            aud.clip = q.Dequeue();
                aud.Play();
            }
	}
}
