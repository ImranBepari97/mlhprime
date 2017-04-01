using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

    public void LoadStage1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void LoadEndGame()
    {
        SceneManager.LoadScene("EndGame");
    }

}

