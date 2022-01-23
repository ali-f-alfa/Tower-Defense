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

    public TowerBluePrint TowerToBuild;
    private Node selectedNode;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one buildManagar in scene!");
            return;
        }
        Instance = this;
    }

    public bool CanBuild {
        get {
            return TowerToBuild != null; 
        } 
    }
    public void SelectTowerToBuild(TowerBluePrint towerBlueprint)
    {
        if (PlayerStats.Coins < towerBlueprint.cost)
        {
            Debug.LogError("Not enough Coins!");
            return;
        }

        TowerToBuild = towerBlueprint;
        selectedNode = null;
    }

    public void BuildOnNode(Node node)
    {
        PlayerStats.Coins -= TowerToBuild.cost;
        Debug.Log("Tower build! coins left: " +  PlayerStats.Coins);

        GameObject Tower = (GameObject)Instantiate(TowerToBuild.prefab, node.transform.position + new Vector3(0f, 0.25f, 0f), node.transform.rotation);
        node.Tower = Tower;
        TowerToBuild = null;
    }

    public void SelectNode(Node node)
    {
        selectedNode = node;
        TowerToBuild = null;
    }
}
