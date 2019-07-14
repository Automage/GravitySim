using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody rb;
	public float force = 30f;
	public float torque = 5f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        rb.AddForce(force * transform.forward * Input.GetAxis("Thrust"));

        //y-axis rotation
        if (Input.GetKey("q"))
        {
            rb.AddTorque(transform.forward * torque);
        }
        if (Input.GetKey("e"))
        {
            rb.AddTorque(transform.forward * -torque);
        }

        //vertical (z-axis) rotation
        if (Input.GetKey("w"))
        {
            rb.AddTorque(transform.right * torque);
        }
        if (Input.GetKey("s"))
        {
            rb.AddTorque(transform.right * -torque);
        }

        //horizontal (x-axis) rotation
        if (Input.GetKey("d"))
        {
            rb.AddTorque(transform.up * torque);
        }
        if (Input.GetKey("a"))
        {
            rb.AddTorque(transform.up * -torque);
        }
    }
}
