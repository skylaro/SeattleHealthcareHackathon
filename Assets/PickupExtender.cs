using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PickupExtender : MonoBehaviour
{

    public AudioSource ExtendedSource;
    private Hand.AttachmentFlags attachmentFlags = Hand.defaultAttachmentFlags & (~Hand.AttachmentFlags.SnapOnAttach) & (~Hand.AttachmentFlags.DetachOthers);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnItemPickup()
    {
        Debug.Log("Don't worry guys, I got this!");

        //AudioSource aud = GameObject.Find("narration").GetComponent<AudioSource>();

        if (ExtendedSource != null)
        {
            if (!ExtendedSource.isPlaying)
            {
                //ExtendedSource..clip = Resources.Load<AudioClip>("scenes/Start_Line_2_CORRECT_N95");
                ExtendedSource.Play();
            }
        }
    }

    public void OnHandHoverBegin(Hand hand)
    {
        if (ExtendedSource != null)
        {
            if (!ExtendedSource.isPlaying)
            {
                //ExtendedSource..clip = Resources.Load<AudioClip>("scenes/Start_Line_2_CORRECT_N95");
                ExtendedSource.Play();
            }
        }
    }
}
