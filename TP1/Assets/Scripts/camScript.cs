using UnityEngine;
using System.Collections;

public class camScript : MonoBehaviour {
	public float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (-Input.GetAxis("Mouse Y")*speed, Input.GetAxis("Mouse X")*speed, 0.0f);
		transform.Translate(Input.GetAxis("Horizontal")*speed,0.0f,Input.GetAxis("Vertical")*speed);
	}
}
