using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delate : MonoBehaviour
{
    public float time;
    public float lemit;
    void Update()
    {
        time += Time.deltaTime * 5;
        if (time > lemit)
        {
            Destroy(gameObject);
        }
    }
}