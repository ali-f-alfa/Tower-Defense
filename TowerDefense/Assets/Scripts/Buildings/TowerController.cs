using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    private Transform target;
    public float range = 10f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    public GameObject ShellPrefab;
    public Transform ShootPoint;

    private string groundEnemiesTag = "GroundEnemies";
    private AudioSource arrowSound;
    void Start()
    {
        arrowSound = GetComponent<AudioSource>();
        InvokeRepeating("UpdateTarget", 0f, 0.3f);
    }

    void Update()
    {
        if (target == null)
            return;



        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;

    }

    void Shoot()
    {
        Vector3 dir = target.position + new Vector3(0f, 1.5f, 0f) - ShootPoint.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        ShootPoint.rotation = Quaternion.Euler(rotation.x + 90, rotation.y, rotation.z);

        GameObject ShellGO = (GameObject)Instantiate(ShellPrefab, ShootPoint.position, ShootPoint.rotation);
        Shell shell = ShellGO.GetComponent<Shell>();

        if (shell != null)
            shell.SetTarget(target);

        arrowSound.Play();
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(groundEnemiesTag);
        float ShortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            if (enemy.GetComponent<SoldierController>().state != SoldierStates.DIE)
            {
                float dist = Vector3.Distance(transform.position, enemy.transform.position);
                if (dist < ShortestDistance)
                {
                    ShortestDistance = dist;
                    nearestEnemy = enemy;
                }
            }
        }
        if (nearestEnemy != null && ShortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
