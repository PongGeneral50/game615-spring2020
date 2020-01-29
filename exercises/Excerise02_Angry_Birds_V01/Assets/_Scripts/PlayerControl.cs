using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public GameObject piggy;
    public float power = 50f;
    private Rigidbody2D piggyBody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseInWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));

        Vector3 direction = mouseInWorld - transform.position;

        float alpha = Mathf.Acos(

        Vector3.Dot(Vector3.right, direction.normalized)) * Mathf.Rad2Deg;

        if (alpha <= 0 && alpha > 0 && direction.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, alpha * Mathf.Rad2Deg);

            if (Input.GetButtonDown("Fire1"))
            {
                piggy.transform.parent = null;
                piggyBody.gravityScale = 1;
                piggyBody.AddForce(direction * power);
            }
        }
    }
}