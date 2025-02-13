using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtacAi : MonoBehaviour
{
    public int valueDown;
    public GameObject no;
    public int iie;//1 уничтожается    0 не уничтожается    2 меч    3 у врага
    void OnTriggerEnter(Collider col)
    {
        if (iie == 1)
        {
            if (col.gameObject.GetComponent<enemyXP>())
            {
                col.GetComponent<enemyXP>().HealthAU -= valueDown;
            }
            if (col.gameObject.GetComponent<AtacAi>()==null)
            {
                Destroy(gameObject);
            }
        }
        else if (iie == 0)
        {
            if (col.gameObject.GetComponent<enemyXP>())
            {
                col.GetComponent<enemyXP>().HealthAU -= valueDown;
            }
        }
        else if (iie == 3)
        {
            if (col.gameObject.GetComponent<enemyXP>() && col.gameObject != no)
            {
                col.GetComponent<enemyXP>().HealthAU -= valueDown;
            }
        }
        else
        {
            if (col.gameObject.GetComponent<enemyXP>())
            {
                if (col.gameObject.GetComponent<Block>() == null)
                {
                    col.GetComponent<enemyXP>().HealthAU -= valueDown;
                }
            }
        }
    }
}