using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    //get player, rb, anim dunno if we are going to have anims
    public Transform player;
    public Rigidbody2D rb;
    public int speed;
    public int health;
    public int maxHealth;

    void Awake()
    {
        health = maxHealth;
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        rb.velocity = new Vector3(direction.x, direction.y) * speed;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "bullet")
        {
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
