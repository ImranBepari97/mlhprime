using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    [SerializeField]
    float forwardMomentum;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        forwardMomentum = 5f;
    }
	
	// Update is called once per frame
	void Update () { 
	}

    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * forwardMomentum);
    }
}
