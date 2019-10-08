﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Enemy : MonoBehaviour
{
    public float speed = 10f; //use scriptable objects with this

    private Transform target;
    private int wavepointIndex = 0;
    
    void Start()
    {
        target = scr_Waypoints.points[0];
    }
    
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= scr_Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
        }
        wavepointIndex++;
        target = scr_Waypoints.points[wavepointIndex];
    }
}