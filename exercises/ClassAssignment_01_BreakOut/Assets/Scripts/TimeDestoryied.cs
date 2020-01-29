using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestoryied : MonoBehaviour
{

    public float destoryTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destoryTime);
    }
}
