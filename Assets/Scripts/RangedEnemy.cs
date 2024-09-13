using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RangedEnemy : Enemy
{
    public int distance;
    public GameObject bullet;
    public override Vector2 FindLocation(Vector2 player)
    {
        Vector2 us = this.transform.position;
        if (Math.Pow((Math.Abs(player.x-us.x)),2)+(Math.Pow(Math.Abs(player.y-us.y),2)) == Math.Pow(distance,2))//I can definantly do this better
        {
            return us;
        } else if(Math.Pow((Math.Abs(player.x-us.x)),2)+(Math.Pow(Math.Abs(player.y-us.y),2)) < Math.Pow(distance,2))
        {
            return -player;//this fucks stuff up but only sometimes
        }else 
        {
            return player;
        }
        
    }

    public override void Shoot()
    {
        GameObject.Instantiate(bullet, transform.position, this.transform.rotation);//change rotation to the angle
        //shoot, i need to find an angle and idk how to do that
    }
}
