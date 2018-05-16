using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	//void Start () {
	//	
	//}
	public int OpenWorldIndex;
	public int TutorialIndex;


	public void ContinueToOpenWorld(){
		SceneManager.LoadScene (0);
	}
	public void ToTutorial(){
		SceneManager.LoadScene (1);
	}
	public void SetQuality(int qualityIndex){
		QualitySettings.SetQualityLevel (qualityIndex);
	}
}
