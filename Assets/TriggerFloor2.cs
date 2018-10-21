using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFloor2 : MonoBehaviour {

    public GameObject middleR2;
    public GameObject floor2;
    public Animator heavenStairs;
    public Animator rotateRoom2;
    public AudioSource scaryLaugh;
    public GameObject R2objects;
    public GameObject R3;
    public GameObject R1R2;

    public static bool entered;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Objec trigger floor room2: " + other.name);

        if (entered == false && other.name.StartsWith("[VRTK][AUTOGEN]"))
        {
	       middleR2.SetActive(true);
            createShortMessage(MenuText.SPIDER_BURROW, 5);
            //Debug.Log("Playing animation Room2FloorAppear");
            floor2.SetActive(true);
            heavenStairs.Play("HeavenStairsFade");
            rotateRoom2.Play("RotateRoom2");
            scaryLaugh.Play();
            Invoke("createObjects", 9);
            Invoke("updateScene", 15);            //R2objects.SetActive(true);
            entered = true;
            //heavenStairs.Play("none");
        }
        //switch (other.name)
        //{


        //    case "[VRTK][AUTOGEN][FootColliderContainer]":
        //        if (entered == false)
        //        {
        //            Debug.Log("Playing animation Room2FloorAppear");
        //            floor2.SetActive(true);
        //            heavenStairs.Play("HeavenStairsFade");
        //            rotateRoom2.Play("RotateRoom2");
        //            scaryLaugh.Play();
        //            Invoke("createObjects", 2);
        //            //R2objects.SetActive(true);
        //            entered = true;
        //            //heavenStairs.Play("none");
        //        }
        //        break;
        //    default:
        //        Debug.Log("Unidentified object entered");
        //        break;
        //}
    }

    private void createObjects(){
         R2objects.SetActive(true);
middleR2.SetActive(false);
    }

    private void createShortMessage(string message, int seconds)
    {
        MenuText.createShortMessage(message);
        Invoke("clearIn", seconds);
    }

    private void updateScene(){
        R1R2.SetActive(false);
        createShortMessage(MenuText.CLIMB_HINT, 4);
        Invoke("readyToClimb", 2);
    }

    private void readyToClimb(){
        R3.SetActive(true);
        floor2.SetActive(false);
    }


    private void clearIn()
    {
        MenuText.clearMessage();
    }
}
