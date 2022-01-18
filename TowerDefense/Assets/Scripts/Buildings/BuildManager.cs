using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance;
    public GameObject Tower0Prefab;
    public GameObject Tower1Prefab;
    public GameObject Tower2Prefab;
    public GameObject Tower3Prefab;
    public GameObject Tower4Prefab;

    private GameObject TowerToBuild;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one buildManagar in scene!");
            return;
        }
        Instance = this;
    }

    public GameObject GetTowerToBuild()
    {
        return TowerToBuild;
    }

    public void SetTowerToBuild(GameObject tower)
    {
        TowerToBuild = tower;
    }
}
