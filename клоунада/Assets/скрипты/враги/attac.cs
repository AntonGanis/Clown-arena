using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attac : MonoBehaviour
{
    public int valueDown;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<xp>())
        {
            col.GetComponent<xp>().Health -= valueDown;
        }
    }
}