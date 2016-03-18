using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Level Load Requested for: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(string name){
		Debug.Log ("I Want to Quit!");
		Application.Quit();
	}
}
