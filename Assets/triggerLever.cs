using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLever : MonoBehaviour {

    public GameObject CristalBall;
    public Animator flipLever;
    public AudioSource keyFalls;
	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        flipLever.Play("FlipRight");
        CristalBall.SetActive(false);
        keyFalls.Play();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
