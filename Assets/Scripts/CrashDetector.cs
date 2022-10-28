using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Debug.Log("You crashed!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
