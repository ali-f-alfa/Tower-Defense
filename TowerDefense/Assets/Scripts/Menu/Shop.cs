using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    public TowerBluePrint tower0Blueprint;
    public TowerBluePrint tower1Blueprint;
    public TowerBluePrint tower2Blueprint;
    public TowerBluePrint tower3Blueprint;
    public TowerBluePrint tower4Blueprint;

    void Start()
    {
        buildManager = BuildManager.Instance;
    }

    public void SelectTower0()
    {
        Debug.Log("tower0 selected");
        buildManager.SelectTowerToBuild(tower0Blueprint);
    }

    public void SelectTower1()
    {
        Debug.Log("tower 1 selected");
        buildManager.SelectTowerToBuild(tower1Blueprint);

    }

    public void SelectTower2()
    {
        Debug.Log("tower 2 selected");
        buildManager.SelectTowerToBuild(tower2Blueprint);
    }

    public void SelectTower3()
    {
        Debug.Log("tower 3 selected");
        buildManager.SelectTowerToBuild(tower3Blueprint);
    }

    public void SelectTower4()
    {
        Debug.Log("tower 4 selected");
        buildManager.SelectTowerToBuild(tower4Blueprint);
    }
}
