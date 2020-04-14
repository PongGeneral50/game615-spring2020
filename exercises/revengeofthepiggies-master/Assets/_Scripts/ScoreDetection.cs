using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetection : MonoBehaviour
{
    public ScoreBoard scoreManager;
    const int TIME_TO_RESET = 3;
    Vector3 orginalposistion;
    Transform parent;
    bool isFirst = false;

     void Start()
    {
        orginalposistion = transform.localPosition;
        parent = transform.parent;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isFirst == false)
        {
            isFirst = true;
            Invoke("ResetPiggy", TIME_TO_RESET);
            if (collision.gameObject.tag != "Floor")
            {
                scoreManager.PiggyColStructure();
                Debug.Log("Score" + scoreManager.getScore());
            }
        }
    }
    void ResetPiggy()
    { 
        transform.position = orginalposistion;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
        GetComponent<Rigidbody2D>().angularVelocity = 0f;
        transform.parent = parent;
        transform.localPosition = orginalposistion;
        Camera.main.GetComponent<CameraFollow>().resetCameraPosition();
        isFirst = false;
    }

}
