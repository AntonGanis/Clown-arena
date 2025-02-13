using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slehka : MonoBehaviour
{
    public Transform target;
    public float speed = 5;
    public bool ky;
    private Transform plar;
    public GameObject rr;
    void Update()
    {
        if (ky == false)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
        else
        {
            plar = rr.GetComponent<HaosControl>().zel.transform;
            Vector3 direction = (plar.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }
}