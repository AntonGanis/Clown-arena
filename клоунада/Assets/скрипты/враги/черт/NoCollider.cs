using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCollider : MonoBehaviour
{
    [SerializeField] private Collider[] _allColl;
    private void Awake()
    {
        for(int i = 0; i <_allColl.Length; i++)
        {
            for(int b = 0; b < _allColl.Length; b++)
            {
                Physics.IgnoreCollision(_allColl[i], _allColl[b], true);
            }
        }
    }
}
