using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory_Barrier : MonoBehaviour
{
	public GameObject TargetToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void BarrierDestoryed(){
		Destroy(TargetToDestroy);
	}
}
