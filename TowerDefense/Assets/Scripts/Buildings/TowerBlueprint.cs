using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TowerBluePrint 
{
    public GameObject prefab;
    public float cost;

    public GameObject upgrade2Prefab;
    public float upgrade2Cost;

    public GameObject upgrade3Prefab;
    public float upgrade3Cost;

    public GameObject upgrade4Prefab;
    public float upgrade4Cost;

    public float GetSellAmount(int level)
    {
        if (level == 1)
        {
            return (cost / 2);
        }

        else if (level == 2)
        {
            return (cost / 2) + (upgrade2Cost / 2);
        }

        else if (level == 3)
        {
            return (cost / 2) + (upgrade2Cost / 2) + (upgrade3Cost / 2);
        }

        else if (level == 4)
        {
            return (cost / 2) + (upgrade2Cost / 2) + (upgrade3Cost / 2) +(upgrade4Cost / 2);
        }

        return 0;
    }

}
