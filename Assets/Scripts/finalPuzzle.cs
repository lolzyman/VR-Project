using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalPuzzle : MonoBehaviour
{
	public float offset;
	public GameObject Pin;
	
	public delegate void OnCollisionEnterDelegate();
	public static event OnCollisionEnterDelegate triggerDelegate;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void OnCollisionEnter(Collision collision)
	{
		//Pin.transform.position += new Vector3(0, 0, -1*offset);
		triggerDelegate ();
	}
}
