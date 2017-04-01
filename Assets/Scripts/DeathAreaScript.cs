using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAreaScript : MonoBehaviour {

    [SerializeField]
    GameObject player;
    [SerializeField]
    GameController gameController;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x , -5, player.transform.position.z);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameController.playing = false;
        }
    }
}
