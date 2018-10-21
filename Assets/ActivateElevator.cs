using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateElevator : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.name == "key")
        {
            TriggerElevator.setActive();
            createShortMessage(MenuText.ELEVATOR_ACTIVE, 3);

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
