using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
	public float unitsPerDegree = 0.001f;

	private float blockMoveDist;
	private float blockMoveDistX;
	private int axis;
	
	public GameObject Pin;
	public GameObject DialBase;
	public GameObject Dial;
	private Vector3 prevPrevRotation;
	private Vector3 mPrevDialRotation;
	
	public GameObject DialBaseX;
	public GameObject DialX;
	private Vector3 prevPrevRotationX;
	private Vector3 mPrevDialRotationX;
	
    // Start is called before the first frame update
    void Start()
    {
		
        mPrevDialRotation = Dial.transform.localEulerAngles;
		mPrevDialRotationX = Dial.transform.localEulerAngles;
		
		finalPuzzle.triggerDelegate += returnPosition;
		
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curDialRotation = Dial.transform.localEulerAngles;
		
		//Vector3 for dial that changes x direction
		Vector3 curDialRotationX = DialX.transform.localEulerAngles;
		
		if(curDialRotation != mPrevDialRotation){
			axis=1;
			
			if(1 == 0){
				
			}
			else{
				float dialRotation = curDialRotation.y - mPrevDialRotation.y;
			
				if(mPrevDialRotation.y > 270 && curDialRotation.y < 90){
					dialRotation +=360;
				}
				else if(mPrevDialRotation.y < 90 && curDialRotation.y >270){
					dialRotation -=360;
				}
			
			
				blockMoveDist = unitsPerDegree*dialRotation;
				Pin.transform.Translate(new Vector3(blockMoveDist,0, 0));
				mPrevDialRotation=curDialRotation;
			}
			
		}
		
		if(curDialRotationX != mPrevDialRotationX){
			axis=2;
			
			float dialRotationX = curDialRotationX.y - mPrevDialRotationX.y;
			
			if(mPrevDialRotationX.y > 270 && curDialRotationX.y < 90){
				dialRotationX +=360;
			}
			else if(mPrevDialRotationX.y < 90 && curDialRotationX.y >270){
				dialRotationX -=360;
			}
			
			
			blockMoveDistX = unitsPerDegree*dialRotationX;
			Pin.transform.Translate(new Vector3(0,0, -blockMoveDistX));
			mPrevDialRotationX = curDialRotationX;
		}
		
    }
	
	void returnPosition()
	{
		Debug.Log("Got to delegate.");
		if(axis == 1){
			Pin.transform.Translate(new Vector3(-1*blockMoveDist*10,0,0));
		}
		else if(axis == 2){
			Pin.transform.Translate(new Vector3(0,0,blockMoveDistX*10));
		}
		
	}
}
