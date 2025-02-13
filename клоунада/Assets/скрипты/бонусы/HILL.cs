using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HILL : MonoBehaviour
{
    GameObject plar;
    public bool r;
    void Start()
    {
        plar = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (r)
        {
            plar.GetComponent<xp>().Health += 3;
        }
    }
}
