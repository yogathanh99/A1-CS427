﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity=transform.right*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name=="Monster1" || col.name=="Monster2"){
            Destroy(col.gameObject);
        }
    }
}
