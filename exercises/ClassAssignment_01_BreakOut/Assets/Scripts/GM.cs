using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {

    public int lives = 3;
    public int bricks = 20;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject gameOver;
    public GameObject youWon;
    public GameObject bricksPrefab;
    public GameObject paddle;
    public GameObject deathParticles;
    public static GM instances = null;

    private GameObject clonePaddel;


    // Start is called before the first frame update
    void Start()
    {
        if (instances == null)
            instances = this;
        else if (instances != this)
            Destroy(gameObject);

        Setup();
    }

    public void Setup()
    {
        clonePaddel = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(bricksPrefab, transform.position, Quaternion.identity);
    }

    void CheckGameOver()
    {
        if (bricks < 1)
        {
            youWon.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }

        if (lives < 1)
        {
           gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }
    }
        void Reset()
{
    Time.timeScale = 1f;
    Application.LoadLevel(Application.loadedLevel);
}
    // Update is called once per frame
    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        Instantiate(deathParticles, clonePaddel.transform.position, Quaternion.identity);
        Destroy(clonePaddel);

        Time.timeScale = 1f;

        clonePaddel = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;

        CheckGameOver();
    }
    void SetupPaddel()
    {
        clonePaddel = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }
   }
public void DestoryBrick()
   {
       Bricks--;
       CheckGameOver();
   }
}