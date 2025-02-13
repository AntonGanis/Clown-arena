using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xp : MonoBehaviour
{
    private GameObject plar;
    public GameObject camera; //камера смэрти
    public GameObject camera2; //камера смэрти
    public GameObject Display;

    public int Health;
    public Slider slider;
    private int MAX;

    void Start()
    {
        plar = GameObject.FindGameObjectWithTag("Player");
        MAX = Health;
    }
    void Update()
    {
        slider.value = Health;
        if (Health <= 0)
        {
            Health = 0;
            Destroy(plar);
            Display.SetActive(false);
            camera.SetActive(true);
            camera2.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        if (Health > MAX)
        {
            Health = MAX;
        }
    }
}
