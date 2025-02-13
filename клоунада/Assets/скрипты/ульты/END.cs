using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END : MonoBehaviour
{
    float time;
    public GameObject MOGILA;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 20)
        {
            Instantiate(MOGILA, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
