using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PressableObjectScript : MonoBehaviour {

    VRTK.Controllables.ArtificialBased.VRTK_ArtificialPusher pusher;
    bool prevIsResting;
    public GameObject gem;

    // Use this for initialization
    void Start () {
        pusher = GetComponent<VRTK.Controllables.ArtificialBased.VRTK_ArtificialPusher>();
        gem.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (prevIsResting && !pusher.IsResting())
        {
            // Button has been pressed
            Debug.Log("Button Pressed");
            gem.SetActive(true);
            AudioSource audios = GetComponent<AudioSource>();
            audios.PlayOneShot(audios.clip);
        }

        prevIsResting = pusher.IsResting();
	}
}
