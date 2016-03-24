using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

	public bool buttonIsClicked;
	// Use this for initialization
	void Start () {
		buttonIsClicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(buttonIsClicked){
			UnityEngine.SceneManagement.SceneManager.LoadScene ("AmericanPool");
		}	
	}

	void OnGUI(){
		buttonIsClicked = GUI.Button(new Rect(0,0,100,50), "Start !");
	}
}
