using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float enemyspeed = 2f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player != null)
        {

            Vector2 direction = (player.position - transform.position).normalized;
            rb.MovePosition(rb.position + direction * enemyspeed * Time.fixedDeltaTime);
        }
    }  
}
