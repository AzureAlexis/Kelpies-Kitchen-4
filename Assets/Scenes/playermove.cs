using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class playermove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = 0;
        float v = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            v += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v -= 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            h -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            h += 1;
        }

        Vector3 inp = new Vector3(h / 5, v / 5, 0);
        GetComponent<Rigidbody2D>().MovePosition(transform.position + inp);

    }
}
