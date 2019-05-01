using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapDoorScript : MonoBehaviour
{
	public float unitsPerDegree = 0.001f;

	private float blockMoveDist;
	private int axis;
	
	public GameObject Pin;
	public GameObject DialBase;
	public GameObject Dial;
	private Vector3 prevPrevRotation;
	private Vector3 mPrevDialRotation;
	
	
    // Start is called before the first frame update
    void Start()
    {
		
        mPrevDialRotation = Dial.transform.localEulerAngles;
		
		finalPuzzle.triggerDelegate += returnPosition;
		
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curDialRotation = Dial.transform.localEulerAngles;
		
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
		
		
    }
	
	void returnPosition()
	{
		//Debug.Log("Got to delegate.");
		if(axis == 1){
			Pin.transform.Translate(new Vector3(-1*blockMoveDist*10,0,0));
		}
		
		
	}
}