using UnityEngine;
using System.Collections;
public class ControllerManager : MonoBehaviour
{
    public bool triggerButtonDown = false;
    public GameObject spotLight;

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device controller
    {

        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);

        }

    }

    private SteamVR_TrackedObject trackedObj;

    private void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Start()
    {

      // trackedObj = GetComponent();

    }

    void Update()
    {
        if (controller.GetHairTriggerDown())
        {
            spotLight.SetActive(true);
        }
        if (controller.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad))
        {
            spotLight.SetActive(false);
        }
        if (controller == null)
        {

            Debug.Log("Controller not initialized");

            return;

        }

        triggerButtonDown = controller.GetPressDown(triggerButton);

        if (triggerButtonDown)
        {

            Debug.Log("Fire");

        }

    }

}
