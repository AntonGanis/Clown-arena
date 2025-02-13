using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordeffect : MonoBehaviour
{
    public int TIP; //зеленый вампир    желтый патронщик    красный берсерк
    GameObject plar;
    public GameObject gannon;
    public GameObject revolver;

    int ss;
    GameObject otherObject;
    void Start()
    {
        ss = gameObject.GetComponent<attac>().valueDown;
        plar = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<enemyXP>())
        {
            if (TIP == 1)
            {
                plar.GetComponent<xp>().Health += 20;
            }
            if(TIP == 2)
            {
                gannon.GetComponent<ganon>().Patroni += 2;
                revolver.GetComponent<revoliver>().Patroni += 7;
            }
        }
        if (col.gameObject.GetComponent<Block>())
        {
            gameObject.GetComponent<attac>().valueDown = 0;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.GetComponent<Block>())
        {
            gameObject.GetComponent<attac>().valueDown = ss;
        }
    }
    private void Update()
    {
        if (otherObject != null)
        {
            Collider otherCollider = otherObject.GetComponent<Collider>();
            if (otherCollider != null)
            {
                if (!otherCollider.bounds.Contains(transform.position))
                {
                    gameObject.GetComponent<attac>().valueDown = ss;
                }
            }
        }
    }
}