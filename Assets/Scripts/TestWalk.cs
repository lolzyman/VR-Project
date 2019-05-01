using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace Valve.VR.InteractionSystem{


public class TestWalk : MonoBehaviour
{
	public SteamVR_Action_Boolean StupidButton;
	public SteamVR_Action_Vector2 WalkAround;
	public SteamVR_Action_Boolean Sprint;
	public SteamVR_Input_Sources thisHand;
	public GameObject targetTransform;
	public double speed = 1;
	public double sprintCoeff = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Handles Sprinting
		double movementSpeed = speed;
		
		if(Sprint.GetState(thisHand)){
			movementSpeed = movementSpeed * sprintCoeff;
		}
		
		//Handles Walk and Strafe
		targetTransform.transform.position += targetTransform.transform.forward * Time.deltaTime * WalkAround.GetAxis(thisHand).y * (float)movementSpeed;
		//Debug.Log(movementSpeed);
		targetTransform.transform.position += targetTransform.transform.right * Time.deltaTime * WalkAround.GetAxis(thisHand).x * (float)speed;
    }
}
}

