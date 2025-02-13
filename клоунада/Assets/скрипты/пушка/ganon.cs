using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganon : MonoBehaviour
{
    public int Patroni;
    int Patroni_Max;
    public int Magaz;

    float time;
    public float Predel;

    public bool on;
    public bool tw;
    void Start()
    {
        Patroni_Max = Patroni;
    }
    void Update()
    {
        time += Time.deltaTime * 5;
        if(Patroni> Patroni_Max)
        {
            Patroni = Patroni_Max;
        }
        if (Input.GetMouseButtonDown(0) & Magaz > 0 & time > Predel && tw == false)
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 1);
            Magaz--;
            time = 0f;
        }
        else if (Input.GetMouseButtonDown(1) && Patroni != 0 && on == false)
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 2);
            int diff = 3 - Magaz;
            if (diff <= Patroni)
            {
                Magaz += diff;
                Patroni -= diff;
            }
            else
            {
                Magaz += Patroni;
                Patroni = 0;
            }
        }
        else
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 0);
        }
    }
}
