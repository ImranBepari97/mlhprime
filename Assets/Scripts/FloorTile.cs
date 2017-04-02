using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTile : MonoBehaviour {

    [SerializeField]
    float timeLeft;
    Transform origin;
    public Transform next;
    public EndlessGameController endless;

	// Use this for initialization
	void Start () {
        timeLeft = 10f;
        origin = transform.Find("Origin");
        next = transform.Find("NextTile");
        transform.Translate(0, 0, -origin.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("went thru it");
            endless.createNextTile();
        }
    }
}
