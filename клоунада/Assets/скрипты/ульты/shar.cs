using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shar : MonoBehaviour
{
    public string enemyTag = "Enemy";
    public float moveSpeed = 5f;
    public float growthRate = 1.5f;
    public float growthDuration = 0.5f;

    private GameObject targetEnemy;
    private bool isMoving = false;

    void Update()
    {
        // ����� ���� �������� � ����� Enemy
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        if (enemies.Length > 0)
        {
            // ������� ��������� ������ Enemy
            float closestDistance = Mathf.Infinity;
            foreach (GameObject enemy in enemies)
            {
                float distance = Vector3.Distance(transform.position, enemy.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    targetEnemy = enemy;
                }
            }

            // ��������� � ���������� ������� Enemy
            if (!isMoving)
            {
                isMoving = true;
                StartCoroutine(MoveAndGrow());
            }
        }
    }

    IEnumerator MoveAndGrow()
    {
        // ��������� � ����
        while (Vector3.Distance(transform.position, targetEnemy.transform.position) > 1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetEnemy.transform.position, moveSpeed * Time.deltaTime);
            yield return null;
        }

        // ����������� ������ � ������� ���� �� ��������� ���� �������
        Vector3 originalScale = transform.localScale;
        Vector3 targetScale = originalScale * growthRate;
        float timer = 0f;
        while (timer < growthDuration)
        {
            timer += Time.deltaTime;
            transform.localScale = Vector3.Lerp(originalScale, targetScale, timer / growthDuration);
            yield return null;
        }

        // ������� ������
        Destroy(gameObject);
    }
}
