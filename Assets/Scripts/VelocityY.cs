using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityY : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y > 0)
        {

            var velY = rb.velocity;
            velY.y = 0;
            rb.velocity = velY;
        }
        
    }
}
