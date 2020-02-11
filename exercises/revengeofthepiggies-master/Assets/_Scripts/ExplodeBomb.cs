using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeBomb : MonoBehaviour

    public GameObject explosion;
{
    // Start is called before the first frame update
    void Update() {

        if (Input.GetButtonDown("Jump"))
    {
        Instantiate(explosion, Transform.posistion, Quaternion.identity);
        gameObject.SetActive(false)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
