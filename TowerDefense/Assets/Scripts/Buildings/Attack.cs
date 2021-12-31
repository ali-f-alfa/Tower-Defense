using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // This script is for buildings & their attacks

    public GameObject[] arrows;

    public float timerMaxTime;
    private float currentTimerValue;

    void Start()
    {
        currentTimerValue = timerMaxTime;
    }

    void Update()
    {
        if (currentTimerValue > 0)
        {
            currentTimerValue -= Time.deltaTime;
        }
        else
        {
            GameObject arrow;

            arrow = Instantiate(arrows[GetRandomPrefabType(arrows.Length)]);

            arrow.transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);

            // reset timer
            currentTimerValue = timerMaxTime;
        }
    }

    int GetRandomPrefabType(int max)
    {
        return UnityEngine.Random.Range(0, max);
    }
}
