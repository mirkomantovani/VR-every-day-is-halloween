using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerElevator : MonoBehaviour {

    public Animator elevator;
    public static GameObject activatedFire;
    public GameObject activatedFireNonStatic;
    //public GameObject room1ceil;
    private static bool active = false;
    private bool entered = false;

    public AudioSource sound;
    public GameObject plasmaParticle;
    private TextMesh userMenu;
    private GameObject userMenuObj;
    public GameObject initialText;

    private readonly String NEED_ACTIVATION;

    internal static void setActive()
    {
        active = true;
        activatedFire.SetActive(true);
    }

    // Use this for initialization
    void Start()
    {
        activatedFire = activatedFireNonStatic;
        //activatedFire = GameObject.Find("FireElevator");
        userMenuObj = GameObject.Find("UserMenu");
        userMenu = userMenuObj.GetComponent<TextMesh>();
        Invoke("deactivateInitialText", 5);

    }

    void OnTriggerEnter(Collider other)
    {

        //for testing
        //active = true;
        //if (other.name == "key"){
        //    active = true;
        //    activatedFire.SetActive(true);
        //    //room1ceil.SetActive(false);
        //}
        if (active && other.name.StartsWith("[VRTK]") && entered == false)
        {
            entered = true;
            elevator.Play("ElevatorUp");

            //Invoke("plasmaExplode", 1);
            sound.Play();
            //Debug.Log("Object entered in elevatot: " + other.name);

        } else if(other.name.StartsWith("[VRTK]")){
            createShortMessage(MenuText.ELEVATOR_NEED_ACTIVATION, 5);
        }
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

    private void deactivateInitialText(){
        initialText.SetActive(false);
    }

    private void plasmaExplode(){
        plasmaParticle.SetActive(true);
    }
}
