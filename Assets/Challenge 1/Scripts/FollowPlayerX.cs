﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    { 
        // transform.Rotate(new Vector3(0, -90, 0));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        offset = new Vector3 (30, 0, 10);
        transform.position = plane.transform.position + offset;
    }
}
