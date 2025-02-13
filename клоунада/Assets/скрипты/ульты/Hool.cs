using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hool : MonoBehaviour
{
    public string enemyTag = "Enemy";
    public float attractionSpeed = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.collider.CompareTag(enemyTag))
                {
                    StartCoroutine(AttractionCoroutine(hit.collider.gameObject));
                }
            }
        }
    }

    IEnumerator AttractionCoroutine(GameObject obj)
    {
        while (Vector3.Distance(obj.transform.position, transform.position) > 1f)
        {
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, transform.position, attractionSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
