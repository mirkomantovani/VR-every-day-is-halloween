using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationIntegration : MonoBehaviour {


    private float speed = 0.022f;
    private bool stop = false;
    private int count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(!stop){
            count++;
            if (count > 420)
                stop = true;
            transform.Translate(- speed, 0, 0);
           //wait = 0;
        }

	}
}
