using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class foodDrop : MonoBehaviour
{
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.Find("Canvas").GetComponent<foodManager>().AddFood(id);
            Destroy(gameObject);
        }
    }
}
