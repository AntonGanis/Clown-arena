using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUNHH : MonoBehaviour
{
    [SerializeField] private GameObject BodyrBox;
   // [SerializeField] private GameObject BodyrBox1;

    public void PunhPunhPunh()
    {
        BodyrBox.SetActive(true);
       // BodyrBox1.SetActive(true);
    }
    public void NoNoNoPunh()
    {
        BodyrBox.SetActive(false);
       // BodyrBox1.SetActive(false);
    }
}