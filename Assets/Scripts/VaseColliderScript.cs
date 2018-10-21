using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseColliderScript : MonoBehaviour {

    public GameObject purple_gem;
    public GameObject green_gem;
    public GameObject yellow_gem;
    public GameObject diamond;

    bool purple_gem_found = false;
    bool green_gem_found = false;
    bool yellow_gem_found = false;
    bool diamond_found = false;

    private int missing = 4;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.Equals(purple_gem.GetComponent<MeshCollider>()) && !purple_gem_found){
            Debug.Log("Purple gem found!");
            purple_gem_found = true;
            playSoundGemFound();
            missing--;
            createShortMessage(MenuText.MISSING_GEMS+missing,3);

        }
        if (other.Equals(yellow_gem.GetComponent<MeshCollider>()) && !yellow_gem_found)
        {
            Debug.Log("Yellow gem found!");
            yellow_gem_found = true;
            playSoundGemFound();
            missing--;
            createShortMessage(MenuText.MISSING_GEMS + missing,3);
        }
        if (other.Equals(green_gem.GetComponent<MeshCollider>()) && !green_gem_found)
        {
            Debug.Log("Green gem found!");
            green_gem_found = true;
            playSoundGemFound();
            missing--;
            createShortMessage(MenuText.MISSING_GEMS + missing,3);
        }
        if (other.Equals(diamond.GetComponent<MeshCollider>()) && !diamond_found)
        {
            Debug.Log("Diamond found!");
            diamond_found = true;
            playSoundGemFound();
            missing--;
            createShortMessage(MenuText.MISSING_GEMS + missing,3);
        }

        if (purple_gem_found && yellow_gem_found && green_gem_found && diamond_found){
            Debug.Log("All gems found!");
            allGemsFound();
        }
    }

    void allGemsFound (){
        GameObject wall = GameObject.Find("moving_wall");
        wall.GetComponent<Animator>().Play("ApritiSesamo");
        AudioSource wallAudio = wall.GetComponent<AudioSource>();
        wallAudio.PlayOneShot(wallAudio.clip);
        createShortMessage(MenuText.ALL_GEMS_FOUND,4);
    }

    void playSoundGemFound(){
        AudioSource source = GetComponent<AudioSource>();
        source.PlayOneShot(source.clip);
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
