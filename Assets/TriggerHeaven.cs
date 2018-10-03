using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHeaven : MonoBehaviour {

    public Animator heavenStairs;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered in cereal1 trigger: " + other.name);

        switch (other.name)
        {
            case "FlameSkull":
                Debug.Log("Playing animation HeavenStairsAppear");
                heavenStairs.Play("HeavenStairsAppear");
                //heavenStairs.Play("none");
                break;
            default:
                Debug.Log("Unidentified object entered");
                break;
        }
    }

        // Update is called once per frame
        void Update () {
		
	}
}
