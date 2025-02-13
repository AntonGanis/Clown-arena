using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOW : MonoBehaviour
{
    public Transform target;
    public float speed = 5;
    public bool ky;
    private Transform plar;
    public GameObject rr;

    void LateUpdate()
    {
        if (ky == false)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, direction.y, direction.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
        else
        {
            plar = rr.GetComponent<HaosControl>().zel.transform;
            Vector3 direction = (plar.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, direction.y, direction.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }
}
