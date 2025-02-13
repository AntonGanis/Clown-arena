using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looot : MonoBehaviour
{
    public int TIP; // 1=молот 2=меч(красный) 3=револ 4=пушка 5=хилка 6=торт 7=анеки 8=меч(зелёный) 9=меч(желтый)
    GameObject ss;
    public GameObject efaw;

    public WeaponSwitching SS;
    public bool binus;
    void Start()
    {
        ss = GameObject.FindGameObjectWithTag("бааааанусы");
        SS = FindObjectOfType<WeaponSwitching>();
        if (binus)
        {
            TIP = Random.Range(5, 8);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<HaosControl2>())
        {
            if (TIP == 1)
            {
                col.gameObject.GetComponent<HaosControl2>().molot = true;
            }
            else if (TIP == 2 || TIP == 8 || TIP == 9)
            {
                col.gameObject.GetComponent<HaosControl2>().sword = true;
            }
            else if (TIP == 3)
            {
                col.gameObject.GetComponent<HaosControl2>().revol = true;
            }
            else if (TIP == 4)
            {
                col.gameObject.GetComponent<HaosControl2>().gun = true;
            }
            else if (TIP == 5 || TIP == 6 || TIP == 7)
            {
                col.gameObject.GetComponent<HaosControl2>().hil = true;
            }
            Destroy(gameObject);
        }
        if (col.gameObject.GetComponent<xp>())
        {
            if (TIP == 1)
            {
                for (int i = 0; i < SS.weapons.Length; i++)
                {
                    if (SS.weapons[i] == null)
                    {
                        SS.weapons[i] = SS.hammer;
                        break;
                    }
                }
            }
            else if (TIP == 2)
            {
                for (int i = 0; i < SS.weapons.Length; i++)
                {
                    if (SS.weapons[i] == null)
                    {
                        SS.weapons[i] = SS.sword_red;
                        break;
                    }
                }
            }
            else if (TIP == 3)
            {
                for (int i = 0; i < SS.weapons.Length; i++)
                {
                    if (SS.weapons[i] == null)
                    {
                        SS.weapons[i] = SS.revol;
                        break;
                    }
                }
            }
            else if (TIP == 4)
            {
                for (int i = 0; i < SS.weapons.Length; i++)
                {
                    if (SS.weapons[i] == null)
                    {
                        SS.weapons[i] = SS.gun;
                        break;
                    }
                }
            }
            else if (TIP == 5)
            {
                ss.GetComponent<bonus>().two += 1;
            }
            else if (TIP == 6)
            {
                ss.GetComponent<bonus>().one += 1;
            }
            else if (TIP == 7)
            {
                ss.GetComponent<bonus>().three += 1;
            }
            else if (TIP == 8)
            {
                for (int i = 0; i < SS.weapons.Length; i++)
                {
                    if (SS.weapons[i] == null)
                    {
                        SS.weapons[i] = SS.sword_green;
                        break;
                    }
                }
            }
            else if (TIP == 9)
            {
                for (int i = 0; i < SS.weapons.Length; i++)
                {
                    if (SS.weapons[i] == null)
                    {
                        SS.weapons[i] = SS.sword_yellow;
                        break;
                    }
                }
            }
        }
        Destroy(efaw);

    }
}
