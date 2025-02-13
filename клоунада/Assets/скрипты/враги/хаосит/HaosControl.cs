using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaosControl : MonoBehaviour
{
    public GameObject zel;

    public GameObject player;
    private GameObject[] enemies;
    private GameObject[] runes;

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        runes = GameObject.FindGameObjectsWithTag("�����");

        FindClosestObject();
    }

    private void FindClosestObject()
    {
        GameObject closest = null;
        float closestDistance = Mathf.Infinity;
        Vector3 position = transform.position;

        // ����� ���������� Player
        float playerDistance = Vector3.Distance(player.transform.position, position);
        if (playerDistance < closestDistance)
        {
            closest = player;
            closestDistance = playerDistance;
        }

        // ����� ���������� enemy
        foreach (GameObject enemy in enemies)
        {
            if (enemy != gameObject) // ���������, ��� ������� ������ �� �������� enemy
            {
                float enemyDistance = Vector3.Distance(enemy.transform.position, position);
                if (enemyDistance < closestDistance)
                {
                    closest = enemy;
                    closestDistance = enemyDistance;
                }
            }
        }

        // ����� ���������� rune
        foreach (GameObject rune in runes)
        {
            float runeDistance = Vector3.Distance(rune.transform.position, position);
            if (runeDistance < closestDistance)
            {
                closest = rune;
                closestDistance = runeDistance;
            }
        }

        zel = closest;
    }
}