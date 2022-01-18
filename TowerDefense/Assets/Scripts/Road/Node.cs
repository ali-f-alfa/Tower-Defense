using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    //public BuildManager buildManager;

    private GameObject Tower;
    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = this.GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.Instance;
    }

    void OnMouseDown()
    {
        if (buildManager.GetTowerToBuild() == null)
            return;

        if (Tower != null)
        {
            Debug.Log("Can not build there!");
            return;
        }

        GameObject towerToBuild = buildManager.GetTowerToBuild();
        Tower = (GameObject) Instantiate(towerToBuild, transform.position + new Vector3(0f, 0.25f, 0f), transform.rotation);

        buildManager.SetTowerToBuild(null);
    }

    void OnMouseEnter()
    {
        if (buildManager.GetTowerToBuild() == null)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
