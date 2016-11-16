using UnityEngine;
using System.Collections;

public class Movil : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Mover en una direccion

		if(transform.position.z<20)
		{
			transform.Translate (Vector3.forward*Time.deltaTime*20f);
		}
	}
}
