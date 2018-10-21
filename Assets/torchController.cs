using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torchController : MonoBehaviour {

    private bool torchOn = true;

    public void toggleTorch (){
        if (torchOn)
            torchOn = false;
        else
            torchOn = true;
        GetComponent<Light>().gameObject.SetActive(torchOn);
    }

 //   private SteamVR_TrackedObject trackedObject;
 //   public GameObject spotLight;

 //   private SteamVR_Controller.Device Controller{
 //       get { return SteamVR_Controller.Input((int)trackedObject.index); }
 //   }

 //   private void Awake()
 //   {
 //       trackedObject = GetComponent<SteamVR_TrackedObject>();
 //   }


 //   // Use this for initialization
 //   void Start () {
 //       trackedObject = GetComponent();
	//}
	
	//// Update is called once per frame
	//void Update () {
 //       if (Controller.GetHairTriggerDown())
 //       {
 //           spotLight.SetActive(true);
 //       }
 //       if (Controller.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad)){
 //           spotLight.SetActive(false);
 //       }
	//}
}
