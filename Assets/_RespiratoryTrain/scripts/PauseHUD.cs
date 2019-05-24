using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHUD : MonoBehaviour {
    
    private GameObject menu;
    private OVRHapticsClip hc;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //handle pause
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            hc = new OVRHapticsClip(10);
            for (int i = 0; i < 10; i++)
                hc.Samples[i] = i % 2 == 0 ? (byte)0xFF : (byte)0x77;
            hc = new OVRHapticsClip(hc.Samples,10);
            var channel = OVRHaptics.LeftChannel;
                channel.Preempt(hc);

            GameObject[] comps = menu.GetComponentsInChildren<GameObject>();
            if (gameObject.GetComponentInChildren<Canvas>().enabled)
            {
                this.gameObject.GetComponentInChildren<Canvas>().enabled = false;
                
            }
            else
            {
                this.gameObject.GetComponentInChildren<Canvas>().enabled = true;
            }
        }
    }
}
