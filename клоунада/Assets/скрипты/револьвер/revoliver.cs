using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revoliver : MonoBehaviour
{
    public int Patroni;
    int Patroni_Max;
    public int Magaz;
    public int valueDown;

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
        if (Input.GetMouseButtonDown(0) & Magaz > 0 & time > Predel && tw == false)
        {
            Shooting();
            gameObject.GetComponent<Animator>().SetInteger("действие", 1);
            Magaz--;
            time = 0f;
        }
        else if (Input.GetMouseButtonDown(1) && Patroni != 0 && on == false)
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 2);
            int diff = 8 - Magaz;
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
    void Shooting()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000))
        {
            if (hit.collider.GetComponent<enemyXP>())
            {
                hit.collider.GetComponent<enemyXP>().HealthAU -= valueDown;

            }
        }
    }
}
