using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.Instance;
    }

    public void PurchaseTower0()
    {
        Debug.Log("tower0 purchased");
        buildManager.SetTowerToBuild(buildManager.Tower0Prefab);
    }

    public void PurchaseTower1()
    {
        Debug.Log("tower 1 purchased");
        buildManager.SetTowerToBuild(buildManager.Tower1Prefab);

    }

    public void PurchaseTower2()
    {
        Debug.Log("tower 2 purchased");
        buildManager.SetTowerToBuild(buildManager.Tower2Prefab);
    }

    public void PurchaseTower3()
    {
        Debug.Log("tower 3 purchased");
        buildManager.SetTowerToBuild(buildManager.Tower3Prefab);
    }

    public void PurchaseTower4()
    {
        Debug.Log("tower 4 purchased");
        buildManager.SetTowerToBuild(buildManager.Tower4Prefab);
    }
}
