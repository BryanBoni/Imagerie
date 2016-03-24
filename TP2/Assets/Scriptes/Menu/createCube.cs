using UnityEngine;
using System.Collections;

public class createCube : MonoBehaviour {
	public bool createIsClicked;

	// Use this for initialization
	void Start () {
		createIsClicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject tempCube = GameObject.Find ("cube2");

		if (createIsClicked) {
			GameObject.Instantiate (tempCube, tempCube.transform.position + Vector3.up, Quaternion.identity);//add 1 unite in the up direction
		}
	}

	void OnGUI(){
		createIsClicked = GUI.Button (new Rect (100, 100, 100, 100), "Create Cube");
	}
}
