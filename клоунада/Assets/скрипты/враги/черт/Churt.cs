using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Churt : MonoBehaviour
{
    [SerializeField] private ConfigurableJoint _joint;
    [SerializeField] private Transform _pelvis;
    public GameObject anime;
    public Transform plar;
    private float dist;

    void FixedUpdate()
    {
        plar = gameObject.GetComponent<HaosControl>().zel.transform;
        dist = Vector3.Distance(plar.transform.position, transform.position);
        Vector3 toTarget = plar.position - _pelvis.position;
        Vector3 toTargetXZ = new Vector3(toTarget.x, 0, toTarget.z);
        Quaternion rotation = Quaternion.LookRotation(toTargetXZ);
        _joint.targetRotation = Quaternion.Inverse(rotation);
        if (dist<4f)
        {
            anime.GetComponent<Animator>().SetTrigger("атака");
        }
    }
}
