﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementComponent : MonoBehaviour
{
    [SerializeField]    
    private Transform player;

    [SerializeField]
    private Vector3 cameraOffset;

    void LateUpdate()
    {
        transform.position = player.position + cameraOffset;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = player.transform.position + new Vector3(1.5f,10.0f,-27.0f);
    }
}
