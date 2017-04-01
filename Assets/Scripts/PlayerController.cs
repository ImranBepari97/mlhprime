using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    float turnSpeed;
    [SerializeField]
    GameObject cameraShell;
    [SerializeField]
    GameObject directionChild;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
      

    }

    void FixedUpdate()
    {
        rb.AddForce(directionChild.transform.forward * speed);
        cameraShell.transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed, 0);
        directionChild.transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed, 0);

    }
}
