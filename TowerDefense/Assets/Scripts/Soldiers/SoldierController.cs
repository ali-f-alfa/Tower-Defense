using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{
    public SoldierStates state;
    public float moveFactor;
    private Transform target;
    private int wavepointIndex = 0;
    
    void Start()
    {
        state = SoldierStates.MOVE;
        target = Waypoints.points[wavepointIndex];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * moveFactor * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
        
    }

    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];

        //Debug.Log(horizontalInput);
        Vector3 dir = target.position - transform.position;
        dir.Normalize();

        if (dir != Vector3.zero)
        {

            transform.forward = dir;
        }
    }
}
