using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public int score;
    public bool playing;

	// Use this for initialization
	void Start () {
        playing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (playing)
        {
            score += 1 + (int) Time.deltaTime;
        } else
        {
            //insert code for game over
        }
	}
}
