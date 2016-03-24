using UnityEngine;
using System.Collections;

public class trannslateScript : MonoBehaviour {
	public float planX;
	public float planZ;
	public float angle = 0; 
	public float radius = 5;
	public float vitesse = (2*Mathf.PI)/5; //2*pi in degress is 360, so you get 5 seconds to complete a circle

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		angle += vitesse * Time.deltaTime;
		planX = Mathf.Cos (angle) * radius;
		planZ = Mathf.Sin (angle) * radius;

		transform.Translate (planX, 0.0f, planZ);
	}
	
}
