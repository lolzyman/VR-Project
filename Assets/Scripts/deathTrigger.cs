using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deathTrigger : MonoBehaviour
{
	
	public float deathHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
        if(gameObject.transform.position.y < deathHeight)
		{
			Scene currentScene = SceneManager.GetActiveScene();
			string sceneName = currentScene.name;
			
			if(sceneName == "IntroLevel" || sceneName == "CallibrationScene"){
				SceneManager.LoadScene("IntroLevel");
			}
			
			else{
				SceneManager.LoadScene("Hub");
			}
			
			
		}
    }
}
