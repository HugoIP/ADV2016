using UnityEngine;
using System.Collections;

public class CreateBuilding : MonoBehaviour {
    public GameObject floor;
    public int maximunfloor = 3;
    public int minimunfloor = 1;
    public int randFloor;
    public Color32 color;

	// Use this for initialization
	void Start () {
        // pick a random color
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        

        randFloor = Random.Range(minimunfloor, maximunfloor);
        for (int f=0;f<randFloor;f++)
        {
            GameObject b =  GameObject.Instantiate(floor, new Vector3(this.transform.position.x, this.transform.position.y + f, this.transform.position.z),Quaternion.identity) as GameObject;
            // apply it on current object's material
            b.gameObject.GetComponent<Renderer>().material.color = newColor;

        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
