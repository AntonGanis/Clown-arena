using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightFoot : MonoBehaviour
{
    public GameObject toli;
    Vector3 newVector3;
    public float ZO;
    public float XO;

    void Update()
    {
        XO = toli.GetComponent<knight>().atakaX;
        ZO = toli.GetComponent<knight>().atakaZ;
        newVector3 = new Vector3(XO, -1, ZO);
        transform.localPosition = newVector3;
    }
}
