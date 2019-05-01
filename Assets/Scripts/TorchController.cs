using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem{
public class TorchController : MonoBehaviour
{
	public enum torchColorOptions {Green = 0, Red = 1, Yellow = 2, Black = 3};
	public torchColorOptions TorchColor;
	public static int size;
	public GameObject[] fireSources = new GameObject[size];
	private Transform fireController;
	public int currentColor = -1;
	
	public bool lit = false;
	public bool islightable = false;
	public bool grabbable;
    // Start is called before the first frame update
    void Start()
    {
        fireController = gameObject.transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
		if(lit){
			setFireColor((int)TorchColor);
		}
    }
	
	void setFireColor(int fireColor){
		if(currentColor != fireColor){
			//Debug.Log("Tried TO Light");
			foreach (Transform child in fireController.transform) {
				GameObject.Destroy(child.gameObject);
			}
			GameObject clone1;
            clone1 = Instantiate(fireSources[fireColor], fireController.transform.position, fireController.transform.rotation);
            clone1.transform.parent = fireController;
			if(islightable || currentColor == -1){
				currentColor = fireColor;
				TorchColor = (torchColorOptions)fireColor;
			}
			
			Debug.Log(fireColor);
		}
		
	}
	
	public int getTorchColor(){
		return (int)TorchColor;
	}
	
	void setFireColorFromOtherObject(Transform OtherFireSource){
		if(islightable){
		if(!lit){
			setFireColor(OtherFireSource.parent.GetComponent<TorchController>().getTorchColor());
			Debug.Log("Flame Tried TO Appear");
		}else if(transform.parent == null && lit){
			setFireColor(OtherFireSource.parent.GetComponent<TorchController>().getTorchColor());
		}
		}
		lit = true;
	}
}
}