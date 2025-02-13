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
        // Поиск всех объектов с тегом Enemy
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        if (enemies.Length > 0)
        {
            // Находим ближайший объект Enemy
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

            // Двигаемся к ближайшему объекту Enemy
            if (!isMoving)
            {
                isMoving = true;
                StartCoroutine(MoveAndGrow());
            }
        }
    }

    IEnumerator MoveAndGrow()
    {
        // Двигаемся к цели
        while (Vector3.Distance(transform.position, targetEnemy.transform.position) > 1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetEnemy.transform.position, moveSpeed * Time.deltaTime);
            yield return null;
        }

        // Увеличиваем объект в полтора раза за указанную долю секунды
        Vector3 originalScale = transform.localScale;
        Vector3 targetScale = originalScale * growthRate;
        float timer = 0f;
        while (timer < growthDuration)
        {
            timer += Time.deltaTime;
            transform.localScale = Vector3.Lerp(originalScale, targetScale, timer / growthDuration);
            yield return null;
        }

        // Удаляем объект
        Destroy(gameObject);
    }
}
