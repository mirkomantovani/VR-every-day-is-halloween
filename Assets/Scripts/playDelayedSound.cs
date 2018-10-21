using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playDelayedSound : MonoBehaviour {


    public AudioSource sound;
    public int seconds;

    void Start()
    {
        StartCoroutine(WaitAndPlay());
    }

    IEnumerator WaitAndPlay()
    {
        yield return new WaitForSeconds(seconds);
        sound.Play();

    }

}
