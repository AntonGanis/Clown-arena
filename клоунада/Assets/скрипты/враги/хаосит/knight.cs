using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    public float speedwww;

    public GameObject XPlus;
    public GameObject XMinus;
    public GameObject ZPlus;
    public GameObject ZMinus;

    public float _speed;
    public float Up;
    public float gravity;
    private Transform plar;

    private float tim;
    private float time;
    public float lema;
    public float lematim;
    public float atakaX;
    public float atakaZ;

    float speed_Move;
    float x_Move;
    float z_Move;
    CharacterController Koli;
    Vector3 move_Direction;

    private float dist;
    public float back;
    public GameObject FOOT;

    void Start()
    {
        Koli = GetComponent<CharacterController>();
    }
    void Update()
    {
        plar = gameObject.GetComponent<HaosControl>().zel.transform;
        dist = Vector3.Distance(plar.position, transform.position);
        Move();
        if (dist<back)
        {
            FOOT.GetComponent<slehka>().ky = false;
            time = time + 0.1f;
            tim = tim + 0.1f;
            if (tim > lematim)
            {
                atakaX = Random.Range(-1, 1);
                atakaZ = Random.Range(-1, 1);
                tim = 0f;
            }
            if (atakaX == 0f && atakaZ == 0f)
            {
                atakaX = Random.Range(-1, 1);
                atakaZ = Random.Range(-1, 1);
            }
            if (XPlus.GetComponent<XPoint>().ero == true)
            {
                atakaX = -1f;
            }
            if (XMinus.GetComponent<XPoint>().ero == true)
            {
                atakaX = 1f;
            }

            if (ZPlus.GetComponent<XPoint>().ero == true)
            {
                atakaZ = -1f;
            }
            if (ZMinus.GetComponent<XPoint>().ero == true)
            {
                atakaZ = 1f;
            }
        }
        else
        {
            FOOT.GetComponent<slehka>().ky = true;
            gameObject.transform.Translate(Vector3.forward * speedwww * Time.deltaTime);
            atakaZ = 0f;
            atakaX = 0f;
        }
    }
    void Move()
    {
        x_Move = atakaX * _speed;
        z_Move = atakaZ * _speed;

        if (Koli.isGrounded)
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);
            if (time > lema)
            {
                move_Direction.y += Up;
                time = 0f;
                lema = Random.Range(27, 30);
            }

        }
        move_Direction.y -= gravity;
        Koli.Move(move_Direction * _speed * Time.deltaTime);
    }
}

