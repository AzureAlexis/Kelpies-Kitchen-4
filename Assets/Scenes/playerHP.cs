using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class playerHP : MonoBehaviour
{
    public int hp;
    public GameObject hpBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemyBullet")
        {
            Destroy(col.gameObject);
            hp += 1;
            if(hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
