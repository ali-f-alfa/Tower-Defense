using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance;
    public GameObject Tower0Prefab;

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

    void Start()
    {
        TowerToBuild = Tower0Prefab;
    }

    void Update()
    {
        
    }

    public GameObject GetTowerToBuild()
    {
        return TowerToBuild;
    }
}
