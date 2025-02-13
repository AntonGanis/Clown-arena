using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confeti : MonoBehaviour
{
    public Transform bullet;
    public float BulletForce;
    public bool boom;
    void Update()
    {
        if (boom)
        {
            Transform BulletInstance = (Transform)Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
            bullet.rotation = gameObject.transform.rotation;
        }
    }
}