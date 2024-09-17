using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bossShoot : MonoBehaviour
{
    public GameObject bullet;
    float shootDelay = 0;
    float dirTick = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootDelay += Time.deltaTime;
        if(shootDelay >= 1f) {
            shootDelay += -0.1f;

            for(int i = 0; i <= 8; i++) {
                GameObject.Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, i * 40 + dirTick));
            }
            dirTick += 5;
            if (dirTick >= 40) {
                dirTick = 0;
            }
        }
    }
}
