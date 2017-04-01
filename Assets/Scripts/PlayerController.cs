using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    [SerializeField]
    float forwardMomentum;
    Transform directionT;
    [SerializeField]
    GameObject gCamera;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        forwardMomentum = 5f;
        directionT = GetComponentInChildren<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        gCamera.transform.Rotate(Input.GetAxis("Horizontal") * forwardMomentum * Time.deltaTime , Input.GetAxis("Horizontal") * forwardMomentum * Time.deltaTime, Input.GetAxis("Horizontal") * forwardMomentum * Time.deltaTime);
        
    }

    void FixedUpdate()
    {
        rb.AddForce(directionT.forward * forwardMomentum);

    }
}
