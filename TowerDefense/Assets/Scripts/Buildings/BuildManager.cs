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

    private Node selectedNode;
    private TowerBluePrint TowerToBuild;
    public NodeUI nodeUI;

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
        DeselectNode();
    }

    public void BuildOnNode(Node node)
    {
        PlayerStats.Coins -= TowerToBuild.cost;
        Debug.Log("Tower build!");

        GameObject Tower = (GameObject)Instantiate(TowerToBuild.prefab, node.transform.position + new Vector3(0f, 0.25f, 0f), node.transform.rotation);
        node.Tower = Tower;
        node.TowerBP = TowerToBuild;
        TowerToBuild = null;
    }

    public void UpgardeOnNode(int level, Node node)
    {
        Destroy(node.Tower);
        if (level == 2)
        {
            if (PlayerStats.Coins < node.TowerBP.upgrade2Cost)
            {
                Debug.LogError("Not enough Coins!");
                return;
            }
            PlayerStats.Coins -= node.TowerBP.upgrade2Cost;

            GameObject Tower = (GameObject)Instantiate(node.TowerBP.upgrade2Prefab, node.transform.position + new Vector3(0f, 0.25f, 0f), node.transform.rotation);
            node.Tower = Tower;
            node.level++;
            Debug.Log("Tower Upgraded to level 2!");

        }
        TowerToBuild = null;
    }

    public void SelectNode(Node node)
    {
        if(selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        TowerToBuild = null;

        nodeUI.SetTraget(node);
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }
}
