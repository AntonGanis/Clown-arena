using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaosControl2 : MonoBehaviour
{
    GameObject plar;
    public GameObject anim;

    float go;
    float dist;
    public int activ;// 1=����� 2=��� 3=����� 4=����� 5=����� 6=������� 7=�����
    public bool revol;
    public bool gun;
    public bool sword;
    public bool molot;
    public bool hil;
    void Start()
    {
        go = gameObject.GetComponent<knight>().back;
    }
    void Update()
    {
        plar = gameObject.GetComponent<HaosControl>().zel;
        dist = Vector3.Distance(plar.transform.position, transform.position);

        if (gameObject.GetComponent<enemyXP>().HealthAU > 70)
        {
            if (plar.tag == "�����")
            {
                gameObject.GetComponent<knight>().back = 1;
            }
            if (plar.tag == "Enemy" || plar.tag == "Player")
            {
                if (molot==true || sword == true)
                {
                    if (molot)
                    {
                        activ = 1;
                    }
                    if (sword)
                    {
                        activ = 2;
                    }
                    gameObject.GetComponent<knight>().back = 1;
                }
                else if (revol == true || gun == true)
                {
                    if (revol)
                    {
                        activ = 3;
                    }
                    if (gun)
                    {
                        activ = 4;
                    }
                    gameObject.GetComponent<knight>().back = 20;
                }
                else
                {
                    gameObject.GetComponent<knight>().back = 20;
                }
            }
        }
        else
        {
            gameObject.GetComponent<knight>().back = 20;
            if (revol == true || gun == true)
            {
                if (revol)
                {
                    activ = 3;
                }
                if (gun)
                {
                    activ = 4;
                }
            }
            if (hil == true)
            {
                activ = 5;
            }
        }
        if (activ == 1)
        {
            anim.GetComponent<Animator>().SetInteger("��������", 1);
        }
        else if (activ == 2)
        {
            anim.GetComponent<Animator>().SetInteger("��������", 2);
        }
        else if (activ == 3)
        {
            anim.GetComponent<Animator>().SetInteger("��������", 3);
        }
        else if (activ == 4)
        {
            anim.GetComponent<Animator>().SetInteger("��������", 4);
        }
        else if (activ == 5)
        {
            hil = false;
            gameObject.GetComponent<enemyXP>().HealthAU += 60;
        }
        else
        {
            anim.GetComponent<Animator>().SetInteger("��������", 0);
        }
    }
}
