using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bonus : MonoBehaviour
{
    public bool yes;

    public int one;// торт
    public Text t1;
    public int two;// банан
    public Text t2;
    public int three;// анеки
    public Text t3;

    private void Start()
    {
        t1 = t1.gameObject.GetComponent<Text>();
        t2 = t2.gameObject.GetComponent<Text>();
        t3 = t3.gameObject.GetComponent<Text>();
    }
    void Update()
    {
        t1.text = "X" + one.ToString("D1");
        t2.text = "X" + two.ToString("D1");
        t3.text = "X" + three.ToString("D1");
        if (Input.GetKeyDown(KeyCode.Alpha1) && one != 0 && yes == false)
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 1);
            one--;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && two != 0 && yes == false)
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 2);
            two--;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && three != 0 && yes == false)
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 3);
            three--;
        }
        else
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 0);
        }
    }
}
