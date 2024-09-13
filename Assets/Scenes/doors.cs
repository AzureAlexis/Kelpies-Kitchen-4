using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour
{
	GameObject cam;
    Vector3 relPos;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if(other.gameObject.tag == "Player") {
			relPos = cam.GetComponent<Camera>().WorldToViewportPoint(transform.position);
			Debug.Log(relPos);
			if(relPos.y > 0.7) {
				cam.GetComponent<camMove>().SetTarget(transform.position + new Vector3(3, 5.5f, -10f));
			}
			else if(relPos.y < 0.3) {
				cam.GetComponent<camMove>().SetTarget(transform.position + new Vector3(3, -5.5f, -10f));
			}
			else if(relPos.x < 0.3) {
				cam.GetComponent<camMove>().SetTarget(transform.position + new Vector3(-4.5f, 0, -10f));
			}
			else if(relPos.x > 0.6) {
				cam.GetComponent<camMove>().SetTarget(transform.position + new Vector3(10.5f, 0, -10f));
			}
		}
	}
}