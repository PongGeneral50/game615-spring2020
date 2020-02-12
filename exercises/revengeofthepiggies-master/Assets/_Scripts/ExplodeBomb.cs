﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeBomb : MonoBehaviour {

    public GameObject explosion;
    void Update() {

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}