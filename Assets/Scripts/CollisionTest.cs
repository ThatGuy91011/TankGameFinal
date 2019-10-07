﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (tf.position.y < 13 && tf.position.y > -13 && tf.position.x < 13 && tf.position.x > -13)
        {
            Destroy(other.gameObject);
        }
    }
}
