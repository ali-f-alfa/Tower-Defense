using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierGenerator : MonoBehaviour
{
    public List<GameObject> allAliveEnemies;
    public GameObject enemy0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public float maxEnemyGapTimer = 2.0f;
    public float maxLevelTimer = 120.0f;
    public float enemyGapTimer;
    public float levelTimer;

    public float enemy0RandomRange;
    public float enemy1RandomRange;
    public float enemy2RandomRange;
    public float enemy3RandomRange;

    private Vector3 StartingPoint;
    void Start()
    {
        StartingPoint = new Vector3(-2, 0.25f, -5);
        allAliveEnemies = new List<GameObject>();
        //SkinnedMeshRenderer SMR = gameObject.GetComponent<SkinnedMeshRenderer>();
        CreateSoldier(SoldierType.Type0, StartingPoint);
        enemy0RandomRange = 0.4f;
        enemy1RandomRange = 0.7f;
        enemy2RandomRange = 0.9f;
        enemy3RandomRange = 1.0f;
        levelTimer = maxLevelTimer;
        enemyGapTimer = maxEnemyGapTimer;
    }

    void Update()
    {
        enemyGapTimer -= Time.deltaTime;
        levelTimer -= Time.deltaTime;

        // time to create a new enemy
        if (enemyGapTimer <= 0)
        {
            SoldierType soldierType = setNewSoldierType();            
            CreateSoldier(soldierType, StartingPoint);
            enemyGapTimer = maxEnemyGapTimer;
        }

        if ((levelTimer <= 0))
        {
            if (maxEnemyGapTimer >= 0.5f)
            {
                maxEnemyGapTimer -= 0.4f;
            }
            levelTimer = maxLevelTimer;
        }

    }

    public SoldierType setNewSoldierType()
    {
        System.Random random = new System.Random();
        var number = random.NextDouble();
        if (number < enemy0RandomRange)
        {
            return SoldierType.Type0;
        }
        if (number < enemy1RandomRange)
        {
            return SoldierType.Type1;
        }
        if (number < enemy2RandomRange)
        {
            return SoldierType.Type2;
        }
        else
        {
            return SoldierType.Type3;
        }
    }



    public GameObject CreateSoldier(SoldierType soldierType, Vector3 position)
    {
        GameObject enemy;

        if (soldierType == SoldierType.Type0)
        {
            enemy = Instantiate(enemy0);
        }
        else if (soldierType == SoldierType.Type1)
        {
            enemy = Instantiate(enemy1);
        }
        else if (soldierType == SoldierType.Type2)
        {
            enemy = Instantiate(enemy2);
        }
        else
        {
            enemy = Instantiate(enemy3);
        }

        enemy.name = "soldier_" + soldierType.ToString();
        enemy.transform.position = position;

        return enemy;
    }
}
