using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyXP : MonoBehaviour
{
    public GameObject MOGILA;
    public GameObject ss;
    public int HealthAU;
    public bool trup;

    void FixedUpdate()
    {
        if (HealthAU < 0)
        {
            HealthAU = 0;
        }
        if (HealthAU <= 0)
        {
            if (trup == true)
            {
                MOGILA.SetActive(true);
                Instantiate(MOGILA, transform.position, transform.rotation);
                Destroy(ss);
            }
        }
    }
}
