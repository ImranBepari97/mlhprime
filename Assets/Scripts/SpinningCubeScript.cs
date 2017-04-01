using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningCubeScript : MonoBehaviour {
    [SerializeField] int spinSpeed;

	// Use this for initialization
	void Start () {
        spinSpeed = 20;

	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
