using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    private Transform target;
    public float speed = 50f;
    public float damage = 50;

    public void SetTarget(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position + new Vector3(0f, 1.5f, 0f) - transform.position;
        float dis = speed * Time.deltaTime;

        if (dir.magnitude <= dis)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * dis, Space.World);
    }

    void HitTarget()
    {
        SoldierController e = target.GetComponent<SoldierController>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }
        Destroy(gameObject);

    }
}
