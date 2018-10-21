using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class LastRoom : MonoBehaviour {

    public GameObject nextRoom;
    public GameObject prevRoom;

    // Use this for initialization
    void Start()
    {
        if (GetComponent<VRTK_InteractableObject>() == null)
        {
            Debug.LogError(tag + " isn't an interactable object!");
            return;
        }
        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
    }

    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        nextRoom.SetActive(true);

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

        createShortMessage(MenuText.END,5);
        
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
