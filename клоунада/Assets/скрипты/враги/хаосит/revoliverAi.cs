using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revoliverAi : MonoBehaviour
{
    public int valueDown;
    public Transform spawn;

    float time;
    public float Predel;


    void Update()
    {
        time += Time.deltaTime * 5;
        if (time > Predel)
        {
            Ray ray = new Ray(spawn.position, transform.forward);
            Debug.DrawRay(spawn.position, transform.forward * 60, Color.red);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.GetComponent<xp>())
                {
                    hit.collider.GetComponent<xp>().Health -= valueDown;
                }
            }
            gameObject.GetComponent<Animator>().SetTrigger("s");
            time = 0f;
        }
    }
}

