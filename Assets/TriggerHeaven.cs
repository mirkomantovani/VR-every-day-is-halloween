using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHeaven : MonoBehaviour {

    public Animator heavenStairs;
    public GameObject heavenStairsObj;
    public GameObject elevator;
    public GameObject wallFlames;
    public GameObject room2;
    public GameObject scareCrow;
    public AudioSource fireexplosion;
    public AudioSource firecrackling;
    public GameObject explosionParticle;
    public GameObject smokeParticle;
    public Animator openDoor;

    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //elevator.SetActive(false);

        switch (other.name)
        {
            case "FlameSkull":
                heavenStairsObj.SetActive(true);
                //Debug.Log("Playing animation HeavenStairsAppear");
                //heavenStairs.Play("HeavenStairsAppear");
                explosionParticle.SetActive(true);
                smokeParticle.SetActive(false);
                Invoke("stopExplosion", 2);
                Invoke("stairsUp", 4);
                wallFlames.SetActive(true);
                elevator.SetActive(false);
                room2.SetActive(true);
                fireexplosion.Play();
                firecrackling.Play();
                scareCrow.SetActive(true);
                openDoor.Play("openDungeonDoor");
                //heavenStairs.Play("none");
                break;
            default:
                Debug.Log("Unidentified object entered:"+ other.name);
                break;
        }
    }

    private void stairsUp(){
        heavenStairs.Play("HeavenStairsAppear");
    }

    private void stopExplosion()
    {
        explosionParticle.SetActive(false);
    }
}
