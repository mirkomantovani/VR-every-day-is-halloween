using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFloor2 : MonoBehaviour {

    public Animator floor2;
    public Animator heavenStairs;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered in cereal1 trigger: " + other.name);

        switch (other.name)
        {
            case "[VRTK][AUTOGEN][FootColliderContainer]":
                Debug.Log("Playing animation Room2FloorAppear");
                floor2.Play("Room2FloorAppear");
                heavenStairs.Play("HeavenStairsFade");
                //heavenStairs.Play("none");
                break;
            default:
                Debug.Log("Unidentified object entered");
                break;
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
