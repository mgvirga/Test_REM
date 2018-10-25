using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    public float gravity = -9.8f;
    public void Attract(Transform body)
    {
        Vector3 gravityup = (body.position - transform.position).normalized;
        Vector3 body1 = body.up;

        body.GetComponent<Rigidbody>().AddForce(gravityup * gravity);

        Quaternion targetrot = Quaternion.FromToRotation(body1, gravityup) * body.rotation;
        body.rotation = Quaternion.Slerp(body.rotation, targetrot, 50 * Time.deltaTime);
    }
}
