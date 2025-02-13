using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ulta : MonoBehaviour
{
    public GameObject rer;
    public GameObject w;
    private bool canActivate = true;
    public float activationTime ;

    void Update()
    {
        if (canActivate)
        {
            w.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.U) && canActivate)
        {
            w.SetActive(false);
            StartCoroutine(ActivateRerForSeconds(activationTime)); // ���������� rer �� 3 �������
            canActivate = false; // ��������� ��������� �� ���������� 60 ������
            StartCoroutine(ResetActivation());
        }
    }

    IEnumerator ActivateRerForSeconds(float seconds)
    {
        rer.SetActive(true);
        yield return new WaitForSeconds(seconds);
        rer.SetActive(false);
    }

    IEnumerator ResetActivation()
    {
        yield return new WaitForSeconds(60f);
        canActivate = true;
    }
}