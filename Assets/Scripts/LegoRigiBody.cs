﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegoRigiBody : MonoBehaviour
{
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RigiBodyConstraint()
    {
        rigidBody.constraints = RigidbodyConstraints.FreezePosition;
    }
}
