using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public Transform target; // ��������� ������� ��������
    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.LookAt(target.transform.position);
    }
}
