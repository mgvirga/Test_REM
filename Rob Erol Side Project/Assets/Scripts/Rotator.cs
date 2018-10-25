using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public GameObject Sun;
    public float x = 0;
    public float y = 1;
    public float z = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Sun.transform.Rotate(new Vector3(x, y, z));
	}
}
