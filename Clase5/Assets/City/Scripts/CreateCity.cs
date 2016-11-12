using UnityEngine;
using System.Collections;

public class CreateCity : MonoBehaviour {
    public GameObject nextDoor;
    public int area=1;
	// Use this for initialization
	void Start () {
        int w = area;
        int h = area;
        for (int x=1;x<w+1;x++)
        {
            for(int y = 1; y < h+1; y++)
            {
                GameObject.Instantiate(nextDoor, new Vector3(this.transform.position.x+((x-(w/2.0f))*10),this.transform.position.y,this.transform.position.z + ((y-(h / 2.0f)) * 10)), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
