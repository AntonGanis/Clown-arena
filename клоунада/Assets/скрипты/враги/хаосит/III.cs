using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class III : MonoBehaviour
{
    public Transform name;
    public bool er;
    void Update()
    {
        if (er == false)
        {
            gameObject.transform.position = name.position;
        }
        else
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
