using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GHHandScript : MonoBehaviour
{
    public GHColorChange theCube;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Store the current hand, and check if the Finger is pinching
        var hand = GetComponent<OVRHand>();
        bool isIndexFingerPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index);

        //Store the active controller, and check for value of the trigger on the left controller
        OVRInput.Controller activeController = OVRInput.GetActiveController();
        float indexTrigger = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);

        //Test if the finger is pinching, OR if the indexTrigger is pressed
        if (isIndexFingerPinching || indexTrigger != 0.0f)
        {
            //is pinching., do something
            theCube.SetGreen();

        }
        else
        {
            //not pinching
            theCube.SetRed();
        }

        float ringFingerPinchStrength = hand.GetFingerPinchStrength(OVRHand.HandFinger.Ring);
    }
}

