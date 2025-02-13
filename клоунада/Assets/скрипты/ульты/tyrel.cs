using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tyrel : MonoBehaviour
{
    public Transform spawn;
    public Transform bullet;
    public float time;
    public float predel;
    public bool naves;
    public float BulletForce;
    void FixedUpdate()
    {
        time += Time.deltaTime * 5;
        if (time > predel)
        {
            if (naves == false)
            {
                Instantiate(bullet, spawn.position, spawn.rotation);
                time = 0f;
            }
            else
            {
                Transform BulletInstance = (Transform)Instantiate(bullet, spawn.position, spawn.rotation);
                BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
                bullet.rotation = spawn.rotation;
                time = 0f;
            }
        }

    }
}