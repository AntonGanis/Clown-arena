using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class animator : MonoBehaviour
{
    [SerializeField] private Transform _tafg;
    private ConfigurableJoint _joint;
    private Quaternion _STpos;
    void Start()
    {
        _joint = GetComponent<ConfigurableJoint>();
        _STpos = transform.localRotation;
    }
    void FixedUpdate()
    {
        _joint.targetRotation = Quaternion.Inverse(_tafg.localRotation) * _STpos;
    }
}
