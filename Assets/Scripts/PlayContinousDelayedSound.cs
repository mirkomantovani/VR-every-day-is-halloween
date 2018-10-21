using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayContinousDelayedSound : MonoBehaviour
{


    public AudioSource sound;
    public int seconds;

    void Start()
    {
        sound.PlayDelayed(12);
        sound.PlayDelayed(15);

        sound.PlayDelayed(18);
        sound.PlayDelayed(21);//for (int i = 0; i < 10; i++)
        //sound.PlayDelayed((3*i)+12);
    }

}
