using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessGameController : MonoBehaviour
{
    public int score;
    public bool playing;
    

    // Use this for initialization
    void Start()
    {
        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            score += 1 + (int)Time.deltaTime;
        }
        else
        {
            //insert code for game over
            SceneManager.LoadScene(1);
        }
    }
}