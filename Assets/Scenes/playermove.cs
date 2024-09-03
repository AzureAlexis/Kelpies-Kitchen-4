using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public GameObject bullet;
    public int power;
    private float tick = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateBullets();

    }

    void UpdateMovement()
    {
        float h = 0;
        float v = 0;

        if (Input.GetKey(KeyCode.W))
        {
            v += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            v -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            h -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            h += 1;
        }

        Vector3 inp = new Vector3(h / 5, v / 5, 0);
        GetComponent<Rigidbody2D>().MovePosition(transform.position + inp);
    }

    void UpdateBullets()
    {
        tick += Time.deltaTime;

        if(tick > 2f / power) 
        {
            tick -= 2f / power;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 0));
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 270));
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 180));
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 90));
            }
        }
    }
}
