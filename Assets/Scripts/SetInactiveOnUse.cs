using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class SetInactiveOnUse : MonoBehaviour {

    public AudioSource source;

    void Start()
    {

        if (GetComponent<VRTK_InteractableObject>() == null)
        {
            Debug.LogError(tag + " isn't an interactable object!");
            return;
        }
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += new InteractableObjectEventHandler(ObjectUsed);
    }

    private void ObjectUsed(object sender, InteractableObjectEventArgs e)
    {
        gameObject.SetActive(false);
        source.PlayOneShot(source.clip);
    }
}
