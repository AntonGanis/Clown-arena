using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    GameObject plar;
    void Start()
    {
        plar = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 2);
        }
        else if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 3);
        }
        else if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 1);
        }
        else if ((Input.GetMouseButton(0) && Input.GetKey(KeyCode.S)) || Input.GetMouseButton(0))
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 4);
        }
        else if (Input.GetMouseButton(1) && plar.GetComponent<Move>().stamina != 0)
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 5);
            plar.GetComponent<Move>().block = true;
        }
        else
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 0);
            plar.GetComponent<Move>().block = false;
        }
    }
}
