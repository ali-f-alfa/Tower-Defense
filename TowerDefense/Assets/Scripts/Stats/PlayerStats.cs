using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
	public static float Coins;
	public float startMoney = 400;

	void Start()
	{
		Coins = startMoney;

	}
}
