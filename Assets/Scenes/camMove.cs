using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{
	Vector3 target = new Vector3(0, 0, -10f);
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 60);
    }
	
	public void SetTarget(Vector3 pos)
    {
        target = pos;
    }
}
