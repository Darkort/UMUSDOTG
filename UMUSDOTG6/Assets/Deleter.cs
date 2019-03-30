using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "asteroid")
        {
            Debug.Log("dasdfasdgfs");
            Destroy(col.gameObject);
                
        }




        Debug.Log("131231231");
    }


}
