using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class useGlassBall : VRTK_InteractableObject
{
    public AudioSource glassSound;
	// Use this for initialization
	void Start () {
		
	}

    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);
        use();
    }

    private void use()
    {
        glassSound.Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
