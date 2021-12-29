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
        StartingPoint = new Vector3(-11, 0, 0);
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



    public GameObject CreateSoldier(SoldierType soldierType, Vector2 position)
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
        enemy.active = true;

        ////SkinnedMeshRenderer SMR = enemy.AddComponent<SkinnedMeshRenderer>();
        ////SMR = gameObject.GetComponent<SkinnedMeshRenderer>();
        ////SpriteRenderer spriteRenderer = enemy.AddComponent<SpriteRenderer>();
        ////var original = gameObject.GetChild(0).gameObject.GetComponent<SkinnedMeshRenderer>();
        ////var type = original.GetType(); ;
        //SkinnedMeshRenderer SMR = enemy.AddComponent<SkinnedMeshRenderer>();
        //SMR.
        //// Copied fields can be restricted with BindingFlags
        //System.Reflection.FieldInfo[] fields = type.GetFields();
        //foreach (System.Reflection.FieldInfo field in fields)
        //{
        //    field.SetValue(SMR, field.GetValue(original));
        //}

        ////EnemyScript enemyScript = enemy.AddComponent<EnemyScript>();
        ////enemyScript.missileMovingSpeed = this.missileMovingSpeed;
        ////enemyScript.MissileSprite = this.MissileSprite;
        ////enemyScript.eventSystem = this.eventSystem;
        ////enemyScript.TypeOfEnemy = soldierType;
        ////enemyScript.GiftSprit = Gift1Sprit;
        ////enemyScript.HeartSprit = HeartSprit;

        ////if (soldierType == EnemiesType.Type1)
        ////{
        ////    spriteRenderer.sprite = EnemyType1Sprite;
        ////    enemy.tag = TagNames.EnemyType1.ToString();
        ////    spriteRenderer.color = new Color(1, 1, 0, 1);
        ////}
        ////else if (soldierType == EnemiesType.Type2)
        ////{
        ////    spriteRenderer.sprite = EnemyType2Sprite;
        ////    enemy.tag = TagNames.EnemyType2.ToString();
        ////    spriteRenderer.color = new Color(0.5f, 0.8f, 0.3f, 1);

        ////}
        ////else if (soldierType == EnemiesType.Type3)
        ////{
        ////    spriteRenderer.sprite = EnemyType3Sprite;
        ////    enemy.tag = TagNames.EnemyType3.ToString();
        ////    spriteRenderer.color = new Color(0, 1, 1, 1);

        ////}


        ////PolygonCollider2D bc = enemy.AddComponent<PolygonCollider2D>() as PolygonCollider2D;
        ////bc.isTrigger = true;

        ////enemyRb.velocity = transform.up * -1 * missileMovingSpeed;
        return enemy;
    }
}
