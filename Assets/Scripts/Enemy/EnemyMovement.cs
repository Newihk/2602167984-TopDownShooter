using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public EnemyScriptableObject enemyData;
    Transform player;
    public float moveSpeed;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyData.moveSpeed * Time.deltaTime);
    }
}
