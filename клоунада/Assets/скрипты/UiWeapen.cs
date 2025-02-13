using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiWeapen : MonoBehaviour
{
    WeaponSwitching SS;
    public int i;

    public GameObject hammer;
    public GameObject sword_red;
    public GameObject sword_yellow;
    public GameObject sword_green;
    public GameObject revol;
    public GameObject gun;

    public GameObject w;

    void Start()
    {
        SS = FindObjectOfType<WeaponSwitching>();
    }

    void Update()
    {
        if(SS.weapons[i] == SS.hammer)
        {
            hammer.SetActive(true);
        }
        else if (SS.weapons[i] == SS.sword_red)
        {
            sword_red.SetActive(true);
        }
        else if (SS.weapons[i] == SS.sword_yellow)
        {
            sword_yellow.SetActive(true);
        }
        else if (SS.weapons[i] == SS.sword_green)
        {
            sword_green.SetActive(true);
        }
        else if (SS.weapons[i] == SS.revol)
        {
            revol.SetActive(true);
        }
        else if (SS.weapons[i] == SS.gun)
        {
            gun.SetActive(true);
        }
        if (SS.selectedWeapon == i)
        {
            w.SetActive(true);
        }
        else
        {
            w.SetActive(false);
        }
    }
}
