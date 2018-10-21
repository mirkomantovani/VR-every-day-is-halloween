using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WerewolfScript : MonoBehaviour {

    public GameObject potion;
    public GameObject treasure;

    private void OnTriggerEnter(Collider other)
    {
        if (other.Equals(potion.GetComponent<BoxCollider>()))
        {
            GetComponent<Animator>().Play("werewolf_death");
            GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
            MenuText.createShortMessage(MenuText.WEREWOLF_DONE);
            treasure.SetActive(true);
        }
    }
}
