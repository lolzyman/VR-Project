using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TeleportScript : MonoBehaviour
{
	
	private bool isTeleporting;
	private float timeTracker;
	
	public string destinationLevel;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		
        if(isTeleporting){
			timeTracker += Time.deltaTime;
			Debug.Log(timeTracker);
		}
		
		gameObject.transform.Rotate(Vector3.up,timeTracker*5);
		
		if(timeTracker > 2f){
			Teleport();
		}
    }
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "LeftHand" ||other.gameObject.name == "RightHand")
		{
			isTeleporting=true;
			timeTracker = 0f;
		}
		
	}
	
	void Teleport()
	{
		SceneManager.LoadScene(destinationLevel);
	}

}
