using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grav_move1 : MonoBehaviour {
    public float movespeed;
    public Vector3 movedir;
	
	void Update () {
        movedir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
	}

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(movedir * movespeed * Time.deltaTime));
    }
}
