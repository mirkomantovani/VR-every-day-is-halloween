using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerR1R2EntrClose : MonoBehaviour {


    public GameObject R1R2entrance;
    public GameObject R1R2;
    public GameObject room1;
    public AudioSource demon;
    public GameObject smokeParticle;
    public GameObject spiderDungeon;
    public Animator bat;

    private static bool entered = false;
	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(entered == false){
            createShortMessage(MenuText.ROOM2, 3);
            smokeParticle.SetActive(true);
            room1.SetActive(false);
            R1R2.SetActive(true);
            demon.Play();
            entered = true;
            spiderDungeon.SetActive(true);
            bat.Play("batFlying");
        }
        //R1R2entrance.SetActive(true);

        //Debug.Log("Unidentified object entered:" + other.name);
    }

    private void createShortMessage(string message, int seconds)
    {
        MenuText.createShortMessage(message);
        Invoke("clearIn", seconds);
    }


    private void clearIn()
    {
        MenuText.clearMessage();
    }


}
