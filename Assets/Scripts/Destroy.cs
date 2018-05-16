using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public GameObject bullet;
    public float time;

	// Use this for initialization
	void Start () {
        Destroy(bullet, time);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
