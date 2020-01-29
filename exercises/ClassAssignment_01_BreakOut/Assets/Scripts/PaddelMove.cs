using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddelMove : MonoBehaviour {

    public float paddelSpeed = 1f;

    private Vector3 playerPos = new Vector3(0, -4.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddelSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -6f, 6f), -4.5f, 0f);
        transform.position = playerPos;
    }
}
