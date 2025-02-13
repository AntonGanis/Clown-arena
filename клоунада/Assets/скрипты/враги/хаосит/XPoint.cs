using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPoint : MonoBehaviour
{
    public bool ero;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WALL")
        {
            ero = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "WALL")
        {
            ero = false;
        }
    }
}

