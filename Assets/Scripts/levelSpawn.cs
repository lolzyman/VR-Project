using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSpawn : MonoBehaviour
{
	
	public Vector3 startPos;
	public Quaternion startRotation;
	
	void Awake()
	{
		GameObject.Find("Player").GetComponent<Rigidbody>().velocity = Vector3.zero;
		GameObject.Find("Player").transform.position = startPos;
		GameObject.Find("Player").transform.rotation = startRotation;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

