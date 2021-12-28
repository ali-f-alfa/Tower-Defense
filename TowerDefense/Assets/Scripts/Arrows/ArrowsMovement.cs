using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsMovement : MonoBehaviour
{
    public ArrowsConfig config;
    public Vector3 move;

    void Start()
    {
        move = new Vector3(-1, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += move;
    }
}
