using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    private Transform target;
    public float speed = 50f;

    public void SetTarget(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
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
        Debug.Log("HIt");
    }
}
