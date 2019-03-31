using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
    bool debug = true;

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "asteroid") {
            if (debug) Debug.Log("asteroid deleted");
            Destroy(col.gameObject); 
        }
    }

}
