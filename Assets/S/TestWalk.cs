using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace Valve.VR.InteractionSystem{


public class TestWalk : MonoBehaviour
{
	public SteamVR_Action_Boolean StupidButton;
	public SteamVR_Action_Vector2 WalkAround;
	public SteamVR_Input_Sources thisHand;
	public GameObject targetTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(StupidButton.GetStateUp(thisHand)){
			Debug.Log("AAHHHHH!!!!");
		}
		Debug.Log(WalkAround.GetAxis(thisHand));
		targetTransform.transform.position += targetTransform.transform.forward * Time.deltaTime*WalkAround.GetAxis(thisHand).y;
    }
}
}

