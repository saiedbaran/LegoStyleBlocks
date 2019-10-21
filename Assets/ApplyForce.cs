﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    [SerializeField] float ForceValue;
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

    private void OnTriggerEnter(Collider collider) 
    {
        collider.GetComponent<Rigidbody>().AddForce(gameObject.transform.up * ForceValue);
    }

}
