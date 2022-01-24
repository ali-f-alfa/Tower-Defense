using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;
    private Node target;

    public Text upgradeCost;
    public Text sellAmount;

    public void SetTraget(Node _target)
    {
        target = _target;
        transform.position = target.transform.position;
        if (target.level == 1)
        {
            upgradeCost.text = "$" + target.TowerBP.upgrade2Cost.ToString();
        }
        else if (target.level == 2)
        {
            upgradeCost.text = "$" + target.TowerBP.upgrade3Cost.ToString();
        }
        else if (target.level == 3)
        {
            upgradeCost.text = "$" + target.TowerBP.upgrade4Cost.ToString();
        }

        sellAmount.text = "$" + target.TowerBP.GetSellAmount(target.level).ToString();
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

    public void Sell()
    {
        target.SellTower();
        BuildManager.Instance.DeselectNode();
    }

}
