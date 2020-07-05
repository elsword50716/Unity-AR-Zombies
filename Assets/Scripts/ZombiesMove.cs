using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesMove : MonoBehaviour
{
    private Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        InvokeRepeating("jump", 3.1f, 3.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
    }
    
    void jump()
    {
        Vector3 next = new Vector3(0, 5, 1);
        rigidbody.AddForce(next*50);
        //transform.Translate(next * Time.deltaTime * 5);

    }
}
