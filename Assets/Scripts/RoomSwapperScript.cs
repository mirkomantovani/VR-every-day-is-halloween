using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwapperScript : MonoBehaviour {

    public GameObject prevRoom, nextRoom;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.name)
        {
            case "[VRTK][AUTOGEN][FootColliderContainer]":
                nextRoom.SetActive(true);

                Debug.Log("Swapping rooms "+prevRoom.name + ", "+nextRoom.name);

                GameObject user = GameObject.Find("[VRTK_SDKManager]");
                Transform userTransform = user.GetComponent<Transform>();

                //Debug.Log("Initial user pos: " + userTransform.position);

                Vector3 prev_pos1 = prevRoom.GetComponent<Transform>().localPosition;
                Vector3 prev_pos2 = nextRoom.GetComponent<Transform>().localPosition;
                prevRoom.transform.localPosition = prev_pos2;
                nextRoom.transform.localPosition = prev_pos1;

                Debug.Log("R1 old pos = " + prev_pos1 + ", new pos = " + prevRoom.transform.localPosition);
                Debug.Log("R2 old pos = " + prev_pos2 + ", new pos = " + nextRoom.transform.localPosition);
                //Debug.Log("New user pos: " + userTransform.position);

                //Deactivate old room to render less things
                prevRoom.SetActive(false);

                createShortMessage(MenuText.ROOM4,3);

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
