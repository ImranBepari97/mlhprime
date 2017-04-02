using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessGameController : MonoBehaviour
{
    public int score;
    public bool playing;
  //  public FloorTile currentTile;
    public GameObject floor_1;
    public Transform floor_pos;
    private Transform previous;
    private Transform next;
    


    // Use this for initialization
    void Start()
    {
        playing = true;
        next = floor_1.transform;
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

    void createTile(Transform temp)
    {
        Instantiate(floor_1, temp);
    }

    public void createNextTile()
    {
        next.position += new Vector3(0, 0, 20.0f);


        Vector3 p1 = transform.position;
        Instantiate(floor_1, next);
        //   currentTile = (FloorTile) Instantiate(currentTile, currentTile.next.transform.position, currentTile.next.transform.rotation);
        //   Transform forward = null;
        //  forward.position = floor_1.transform.position + new Vector3(0f,0f,7.0f);
        //createTile(next);
//next.position = next.position + new Vector3(0f, 0f, 7.0f);
    }


}