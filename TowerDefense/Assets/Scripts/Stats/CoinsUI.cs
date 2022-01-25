using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    public Text CoinsText;

    void Start()
    {
        InvokeRepeating("UpdateCoins", 0f, 0.5f);
    }

    void UpdateCoins()
    {
        CoinsText.text = "$" + PlayerStats.Coins.ToString();
    }
}
