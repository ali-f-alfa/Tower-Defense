using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;
    private Node target;

    public Text upgradeCost;

    public void SetTraget(Node _target)
    {
        target = _target;
        transform.position = target.transform.position;
        if(target.level == 1)
            upgradeCost.text = "$" + target.TowerBP.upgrade2Cost.ToString();
        if (target.level == 2)
            upgradeCost.text = "$" + (target.TowerBP.upgrade2Cost * 2).ToString();//todo: fix cost
        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTower();
        BuildManager.Instance.DeselectNode();
    }

}
