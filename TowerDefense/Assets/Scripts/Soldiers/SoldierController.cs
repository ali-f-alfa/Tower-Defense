using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierController : MonoBehaviour
{
    public SoldierStates state;
    public float moveFactor;
    private Transform target;
    private int wavepointIndex = 0;
    public Transform HealthBar;
    private Quaternion HealthBarDefaultRotation;

    public Image GreenHealhBar;
    public float StartHealth;
    private float Health;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Health = StartHealth;
        HealthBarDefaultRotation = HealthBar.rotation;
        state = SoldierStates.MOVE;
        target = Waypoints.points[wavepointIndex];
    }

    void Update()
    {
        if (state == SoldierStates.MOVE)
        {
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * moveFactor * Time.deltaTime, Space.World);

            if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            {
                GetNextWaypoint();
            }
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
            HealthBar.transform.rotation = HealthBarDefaultRotation;

        }
    }

    public void TakeDamage (float amount)
    {
        Health -= amount;
        GreenHealhBar.fillAmount = Health / StartHealth;
        if(Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        state = SoldierStates.DIE;
        anim.SetInteger("EnemyMode", 2);
        Destroy(gameObject, 4f);
    }
}
