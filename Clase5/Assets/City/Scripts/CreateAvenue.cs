using UnityEngine;
using System.Collections;

public class CreateAvenue : MonoBehaviour {
    public GameObject building;
    public int longAv=10;
    public int split=1;

    // 1 = x+1; and split is z
    // 2 = x-1; and split is z
    // 3 = z+1 and split is x
    // 4 = z -1 and split is x
    public int orientation=1;
	// Use this for initialization
	void Start () {
        for (int o=1;o<5;o++)
        {
            orientation = o;
            for (int av = 1; av < longAv-1; av++)
            {
                
                for (int s = 0; s < 2; s++)
                {
                    int side = split;
                    if (s == 0)
                    {
                        side = split;
                    }
                    else
                    {
                        side = (-split);
                    }
                    if (orientation == 1)
                    {
                        GameObject.Instantiate(building, new Vector3(this.transform.position.x + av, this.transform.position.y, this.transform.position.z + side), Quaternion.identity);
                    }
                    if (orientation == 2)
                    {
                        GameObject.Instantiate(building, new Vector3(this.transform.position.x - av, this.transform.position.y, this.transform.position.z + side), Quaternion.identity);
                    }
                    if (orientation == 3)
                    {
                        GameObject.Instantiate(building, new Vector3(this.transform.position.x + side, this.transform.position.y, this.transform.position.z + av), Quaternion.identity);
                    }
                    if (orientation == 4)
                    {
                        GameObject.Instantiate(building, new Vector3(this.transform.position.x + side, this.transform.position.y, this.transform.position.z - av), Quaternion.identity);
                    }

                }
            }
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
