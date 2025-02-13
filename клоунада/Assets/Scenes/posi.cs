using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posi : MonoBehaviour
{
    public GameObject bon2;//бонус
    GameObject www;
    public float time;
    void Start()
    {
        time = Random.Range(40, 70);
    }
    void Update()
    {
        time += Time.deltaTime;
        if (www == null && time > 60)
        {
            www = Instantiate(bon2) as GameObject;
            www.transform.position = gameObject.transform.position;
            time = 0;
        }
    }
}
