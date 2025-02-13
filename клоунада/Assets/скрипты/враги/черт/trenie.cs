using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trenie : MonoBehaviour
{
    [SerializeField] private PhysicMaterial Tremie1;
    [SerializeField] private PhysicMaterial Tremie0;

    [SerializeField] private Collider _left;
    [SerializeField] private Collider _right;
    public void LeftTremie()
    {
        _left.material = Tremie1;
        _right.material = Tremie0;
    }

    public void RightTremie()
    {
        _left.material = Tremie0;
        _right.material = Tremie1;
    }
}
