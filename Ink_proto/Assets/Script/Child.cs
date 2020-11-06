using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{
	public Transform target;
	public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        GetComponent<Rigidbody>().MovePosition(pos);		
        
    }
}
