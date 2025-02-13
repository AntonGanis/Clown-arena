using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otdacha : MonoBehaviour
{
    public Transform point;
    public float moveSpeed = 5f;
    public float moveDuration = 3f;

    float elapsedTime = 0f;
    bool isMoving = false;

    private void Update()
    {
        if (point != null)
        {
            if (!isMoving)
            {
                isMoving = true;
                elapsedTime = 0f;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, point.position, moveSpeed * Time.deltaTime);
                elapsedTime += Time.deltaTime;
                if (elapsedTime >= moveDuration)
                {
                    point = null;
                    isMoving = false;
                }
            }
        }
    }
}
