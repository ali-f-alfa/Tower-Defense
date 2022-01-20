using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    //public BuildManager buildManager;

    public GameObject Tower;
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
        if (!buildManager.CanBuild)
            return;

        if (Tower != null)
        {
            Debug.Log("Can not build there!");
            return;
        }

        buildManager.BuildOnNode(this);
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
