using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    //public BuildManager buildManager;

    public GameObject Tower;
    public TowerBluePrint TowerBP;
    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    public int level = 1;

    void Start()
    {
        rend = this.GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.Instance;
    }

    void OnMouseDown()
    {
        
        if (Tower != null)
        {
            buildManager.SelectNode(this);
            return;
        }
        if (!buildManager.CanBuild)
            return;


        buildManager.BuildOnNode(this);
    }

    public void UpgradeTower()
    {
        buildManager.UpgardeOnNode(level + 1, this);
    }

    public void SellTower()
    {
        buildManager.SellOnNode(level, this);
    }

    void OnMouseEnter()
    {
        if (!buildManager.CanBuild)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
