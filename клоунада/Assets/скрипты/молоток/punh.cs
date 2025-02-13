using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 2);
        }
        else if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 3);
        }
        else if((Input.GetMouseButton(0) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))) || Input.GetMouseButton(0))
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 1);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetInteger("действие", 0);
        }
    }
}
