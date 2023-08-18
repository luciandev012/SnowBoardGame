using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashBump : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            Debug.Log("Oops!");
        }
    }
}
