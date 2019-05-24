using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class AudioManagerVive : MonoBehaviour {
    public AudioClip AudioClip;
    private AudioSource aud;

    private Hand.AttachmentFlags attachmentFlags = Hand.defaultAttachmentFlags & (~Hand.AttachmentFlags.SnapOnAttach) & (~Hand.AttachmentFlags.DetachOthers);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnAttachedToHand(Hand hand)
    {
        //       AudioSource aud = GameObject.Find("narration").GetComponent<AudioSource>();
        aud = GetComponent<AudioSource>();

        if (!aud.isPlaying)
        {
            //            aud.Play();
            aud.PlayOneShot(AudioClip, 1.0f);
        }
    }

    private void OnDetachedFromHand(Hand hand)
    {
        //do nothing
    }
}
