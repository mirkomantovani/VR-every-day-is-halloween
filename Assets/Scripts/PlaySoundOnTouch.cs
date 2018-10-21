using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PlaySoundOnTouch : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        if (GetComponent<VRTK_InteractableObject>() == null)
        {
            Debug.LogError(tag + " isn't an interactable object!");
            return;
        }
        GetComponent<VRTK_InteractableObject>().InteractableObjectTouched += new InteractableObjectEventHandler(ObjectTouched);
    }

    private void ObjectTouched(object sender, InteractableObjectEventArgs e)
    {
        AudioSource audioS = GetComponent<AudioSource>();
        audioS.PlayOneShot(audioS.clip);
    }
}
