using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RangedEnemy : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public int speed;
    public int distance;
    public GameObject bullet;
    float shootDelay = 0;
    public int health;
    public int maxHealth;

    void Update()
    {
        Movement();
        shootDelay += Time.deltaTime;
        if (shootDelay >= 0.3)
        {
            shootDelay -=0.3f;
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject.Instantiate(bullet, transform.position, this.transform.rotation);
    }

    void Movement()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        if ((player.transform.position - transform.position).magnitude > distance)
        {
            rb.velocity = new Vector3(direction.x, direction.y) * speed;
        } else
        {
            rb.velocity = Vector2.right;
        }

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
