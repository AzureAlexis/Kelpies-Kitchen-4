using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //get, player, rb, anim
    public Transform player;
    public Rigidbody2D rb;
    public Animator anim;
    public float speed;

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector2 player = this.player.position;
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        if (player.x<x)
        {
            x=-speed;
        } else if (player.x>x)
        {
            x=speed;
        }else 
        {
            x=0;
        }
        if (player.y<y)
        {
            y=-speed;
        } else if (player.y>y)
        {
            y=speed;
        } else 
        {
            y=0;
        }

        rb.velocity = new Vector2(x,y);

    }
}
