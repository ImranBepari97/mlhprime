using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAreaScript : MonoBehaviour {

    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject gameController;

	// Use this for initialization
	void Start () {
        gameController = FindObjectOfType<GameController>;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
        }
    }
}
