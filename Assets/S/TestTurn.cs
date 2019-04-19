using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

namespace Valve.VR.InteractionSystem {

public class TestTurn : MonoBehaviour
{
   public SteamVR_Action_Vector2 TurnAround;
   public SteamVR_Input_Sources thisHand;
   public GameObject targetTransform;

        public float speed = 5.0f;


        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            //Vector3  targetPosition = new Vector3(0, TurnAround.GetAxis(thisHand).x, 0);
            //transform.Rotate(targetPosition);

            targetTransform.transform.Rotate(0.0f, TurnAround.GetAxis(thisHand).x * speed * Time.deltaTime, 0.0f);
    }
}
}
