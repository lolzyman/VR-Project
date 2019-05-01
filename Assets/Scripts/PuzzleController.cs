using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem{
public class PuzzleController : MonoBehaviour
{
	public enum torchColorOptions {Green = 0, Red = 1, Yellow = 2, Black = 3};
	public static int enableRequirementsSize;
	public GameObject[] enableRequirements = new GameObject[enableRequirementsSize];
	public torchColorOptions enableCondition;
	public static int resultSize;
	public GameObject[] results = new GameObject[resultSize];
	private bool solved = false;
	public bool enableOnSolved = true;
    // Start is called before the first frame update
    void Start()
    {
        updateResults(!enableOnSolved);
    }

    // Update is called once per frame
    void Update()
    {
        if(solved){
				updateResults(enableOnSolved);
		}else{
			checkPuzzle();
		}
    }
	
	void checkPuzzle(){
		bool notSolved = false;
		foreach( GameObject requirement in enableRequirements){
			TorchController torch = requirement.transform.GetComponent<TorchController>();
			if(torch.getTorchColor() != (int)enableCondition && !torch.lit){
				notSolved = true;
			}
		}
		if(notSolved == false){
			solved = true;
		}
	}
	
	void updateResults(bool newSetting){
		foreach( GameObject result in results){
			result.SetActive(newSetting);
		}
	}
}
}