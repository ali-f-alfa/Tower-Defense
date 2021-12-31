using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsMovement : MonoBehaviour
{
    public ArrowsConfig config;
    public float speedFactor;
    Vector3 move;


    void Start()
    {
        speedFactor = 0.5f;
        move = new Vector3(-1, -1, 0);
        // Rotate randomly when instantiating
        transform.Rotate(Random.Range(0, 60), 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += move * speedFactor;
    }
}
