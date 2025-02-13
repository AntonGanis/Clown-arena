using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opit : MonoBehaviour
{
    public Text t1;
    public GameObject[] enemies;

    void Start()
    {
        t1 = t1.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("κκ");

        t1.text = enemies.Length.ToString("D1");

    }
}
