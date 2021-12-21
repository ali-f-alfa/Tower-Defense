using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{
    public SoldierStates state;
    public float moveFactor;
    
    void Start()
    {
        state = SoldierStates.MOVE;
    }

    void Update()
    {
        if (state == SoldierStates.MOVE)
        {
            this.gameObject.transform.position += new Vector3(moveFactor, 0, 0);
        }
    }
}
