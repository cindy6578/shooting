using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public GameObject myobj;

	// Use this for initialization
	void Start () {
        float x = 10;
        float z = 5;
        for (int i = 0; i < 30; i++)
        {
            x = Random.Range(-20, 20);
            z = Random.Range(-20, 20);
                Instantiate(myobj, new Vector3(x, 0, z), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
