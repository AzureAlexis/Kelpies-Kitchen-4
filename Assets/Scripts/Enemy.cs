using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    //get player, rb, anim dunno if we are going to have anims
    public Transform player;
    public Rigidbody2D rb;
    public Animator anim;
    public int speed;

    void Update()
    {
        Movement(FindLocation(player.position));
        Shoot();
    }

    public virtual Vector2 FindLocation(Vector2 player)
    {
        return player;//this is for melee enemies, overrides in ranged enemies
    }

    public virtual void Shoot(){}

    void Movement(Vector3 location)
    {
        /*I need to do this a lot better
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        if (location.x<x)
        {
            x=-speed;
        } else if (location.x>x)
        {
            x=speed;
        }else 
        {
            x=0;
        }
        if (location.y<y)
        {
            y=-speed;
        } else if (location.y>y)
        {
            y=speed;
        } else 
        {
            y=0;
        }
        
        transform.right = location - transform.position;
        if(this.transform.position.x<location.x || this.transform.position.y<location.y)
        {
            Vector2 v =  transform.right;
            rb.velocity = new Vector2(v.x,v.y) * speed;
        }
        */
        Vector3 diff = location - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot_z);


    }
}
