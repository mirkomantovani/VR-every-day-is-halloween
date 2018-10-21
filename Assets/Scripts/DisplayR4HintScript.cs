using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayR4HintScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        switch (other.name)
        {
            case "[VRTK][AUTOGEN][FootColliderContainer]":
                createShortMessage(MenuText.ROOM4_HINT, 4);
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
