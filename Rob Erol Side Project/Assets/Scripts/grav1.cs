using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grav1 : MonoBehaviour {
    public Gravity attract;
    private Transform current_T;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
        current_T = transform;
	}
	
	// Update is called once per frame
	void Update () {
        attract.Attract(current_T);
	}
}
