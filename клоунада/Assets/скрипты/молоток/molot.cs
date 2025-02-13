using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class molot : MonoBehaviour
{
    public Transform point;
    public GameObject Object;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<otdacha>() && col.gameObject!= Object)
        {
            col.gameObject.GetComponent<otdacha>().point = point;
        }
    }
}
