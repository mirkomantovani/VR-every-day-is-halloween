using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBotola : MonoBehaviour {

    public GameObject botola;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.name)
        {
            case "[VRTK][AUTOGEN][FootColliderContainer]":
                botola.SetActive(true);
                createShortMessage(MenuText.ROOM3,3);
                GameObject.Find("R2").SetActive(false);
                GameObject.Find("R1R2").SetActive(false);
                gameObject.SetActive(false);
                break;
            default:
                Debug.Log("Unidentified object entered");
                break;
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
}
