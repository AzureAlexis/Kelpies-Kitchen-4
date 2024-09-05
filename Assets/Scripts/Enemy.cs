using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Movement(Vector2 location)
    {
        //I need to do this a lot better
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
        
        rb.velocity = new Vector2(x,y);

    }
}
