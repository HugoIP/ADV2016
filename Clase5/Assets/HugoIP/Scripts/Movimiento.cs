using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	//Creamos variable para almacenar el numero de alumnos
	public int contador=8;

	public float distancia=0.5f;
	//0   niño
	//1   niña
	public int genero=0;
	public Color32 color;

	public float acumulador=0;

	//Nombres
	public string profesor="HugoIP";

	// Use this for initialization
	void Start () {
		Debug.Log ("El nombre de este objeto es:       ----------   "+gameObject.name);
	
	}
	
	// Update is called once per frame
	void Update () {
		acumulador = acumulador + Time.deltaTime;

		if(acumulador < 5)
		{
			//azul
			Color newColor = new Color(0,0,1);
			gameObject.GetComponent<Renderer>().material.color = Color.cyan;

		}
		if(acumulador>5)
		{
			//rosa
			Color newColor = new Color(1f,0f, 0f);
			gameObject.GetComponent<Renderer>().material.color = Color.magenta;

		}
		if(acumulador>10)
			acumulador = 0;





		//Gira el objeto que tenga este script
		if(gameObject.name=="Plane"){
			transform.Rotate (Vector3.up * Time.deltaTime * 50.0f);
		}

		if(gameObject.name=="Cube"){
			transform.Rotate (Vector3.down * Time.deltaTime * 50.0f);
		}
	}
}
