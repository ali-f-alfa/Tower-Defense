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

	public static List<int> Level1Wave =
		new List<int>() {
			1,1,1,1,1,
			1,1,1,2,2,2,
			1,2,2,2,2,3,3,
			1,2,2,3,2,2,3,2,
			1,2,3,3,3,4,3,4,3
		};

	public static List<int> Level2Wave =
		new List<int>() {
			1,1,1,1,2,
			1,1,2,2,2,3,
			2,2,2,3,3,3,3,
			2,2,3,2,4,2,3,4,
			1,2,2,3,4,3,3,4,3,
			3,2,3,4,4,4,4,2,3,4
		};

	public static List<int> Level3Wave =
		new List<int>() {
			1,1,1,2,3,
			1,1,2,2,3,3,
			1,2,2,3,3,4,3,
			3,2,1,3,4,4,3,2,
			2,4,4,3,3,4,3,4,3,
			2,4,4,3,3,4,4,4,4,2
		};

	public static List<int> Level4Wave =
		new List<int>() {
			1,1,1,1,1,
			1,1,1,2,2,2,
			1,2,2,2,2,3,3,
			1,2,2,3,2,2,3,2,
			1,2,3,3,3,4,3,4,3
		};

	public static List<int> Level5Wave =
		new List<int>() {
			1,1,1,1,1,
			1,1,1,2,2,2,
			1,2,2,2,2,3,3,
			1,2,2,3,2,2,3,2,
			1,2,3,3,3,4,3,4,3,
			1,2,3,3,3,4,3,4,3,4
		};

	public static List<int> Level6Wave =
		new List<int>() {
			1,1,1,1,1,
			1,1,1,2,2,2,
			1,2,2,2,2,3,3,
			1,2,2,3,2,2,3,2,
			1,2,3,3,3,4,3,4,3,
			1,2,3,3,3,4,3,4,3,4
		};

	public static List<int> Level7Wave =
		new List<int>() {
			1,1,1,1,1,
			1,1,1,2,2,2,
			1,2,2,2,2,3,3,
			1,2,2,3,2,2,3,2,
			1,2,3,3,3,4,3,4,3,
			1,2,3,3,3,4,3,4,3,4
		};

	public static List<int> Level8Wave =
		new List<int>() {
			1,1,1,1,1,
			1,1,1,2,2,2,
			1,2,2,2,2,3,3,
			1,2,2,3,2,2,3,2,
			1,2,3,3,3,4,3,4,3,
			1,2,3,3,3,4,3,4,3,4
		};

	public static List<int> Level9Wave =
		new List<int>() {
			1,1,1,1,1,
			1,1,1,2,2,2,
			1,2,2,2,2,3,3,
			1,2,2,3,2,2,3,2,
			1,2,3,3,3,4,3,4,3,
			1,2,3,3,3,4,3,4,3,4
		};

	public static List<int> Level10Wave =
		new List<int>() {
			1,1,1,1,1,
			1,1,1,2,2,2,
			1,2,2,2,2,3,3,
			1,2,2,3,2,2,3,2,
			1,2,3,3,3,4,3,4,3,
			1,2,3,3,3,4,3,4,3,4,
			1,2,3,4,4,4,4,4,4,4,4
		};

}
