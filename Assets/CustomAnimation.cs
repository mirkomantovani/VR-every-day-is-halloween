using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAnimation : MonoBehaviour {

    public Animator zombie;
	// Use this for initialization
	void Start () {
        for (int count = 1; count <= 5; count++)
        {
           
            zombie.Play("animation");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
