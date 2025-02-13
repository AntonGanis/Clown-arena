using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] bon1;
    public GameObject bon2;//бонус
    public bool d;
    GameObject www;
    public float time;
    void Start()
    {
        time = Random.Range(40, 70);
        d = true;
    }
    void Update()
    {
        time += Time.deltaTime;
        if (www == null && time > 60)
        {
            if (d)
            {
                int i = Random.Range(0, bon1.Length);
                www = Instantiate(bon1[i]) as GameObject;
            }
            else
            {
                www = Instantiate(bon2) as GameObject;
            }
            www.transform.position = gameObject.transform.position;
            d = !d;
            time = 0;
        }
    }
}
