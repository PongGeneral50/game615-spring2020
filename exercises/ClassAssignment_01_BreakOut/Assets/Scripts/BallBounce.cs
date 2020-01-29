using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour {

    public float ballIntialVelocity = 600f;

    private Rigidbody rb;
    private bool ballInPlay;

    // Start is called before the first frame update
    void Awake() {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballIntialVelocity, ballIntialVelocity, 0));
        }
    }
}