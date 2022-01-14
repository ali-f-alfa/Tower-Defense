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

    void Start()
    {
        rend = this.GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (Tower != null)
        {
            Debug.Log("Can not build there! ");
            return;
        }

        GameObject towerToBuild = BuildManager.Instance.GetTowerToBuild();
        Tower = (GameObject) Instantiate(towerToBuild, transform.position, transform.rotation);
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
