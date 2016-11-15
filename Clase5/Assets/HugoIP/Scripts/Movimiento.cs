using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	//Creamos variable para almacenar el numero de alumnos
	public int contador=8;

	public float distancia=0.5f;

	//Nombres
	public string profesor="HugoIP";

	// Use this for initialization
	void Start () {
		Debug.Log ("El nombre de este objeto es:       ----------   "+gameObject.name);
		/*
		if(contador != 0){
			//Forma de acumular un valor en una variable
			//sumando de 1 en 1
			contador = contador + 1;
			//Obligo a que contador sea 0
			contador = 0;
			//contador++;
			//contador += 5;
		}
		else{

		}


		//Loops
		for(int i=0;i<10;i++){
			contador++;
			//contador = i;
		}

		while(contador<10)
		{
			//Codigo que ejecuta
			//Modificar para la condicion
			contador=10;
		}
		*/
	
	}
	
	// Update is called once per frame
	void Update () {
		//Gira el objeto que tenga este script
		if(gameObject.name=="Plane"){
			transform.Rotate (Vector3.up * Time.deltaTime * 50.0f);
		}
		else
		{
			transform.Rotate (Vector3.down * Time.deltaTime * 50.0f);
		}

	}
}
