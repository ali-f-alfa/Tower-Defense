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

    private Vector3 StartingPoint;
    void Start()
    {
        StartingPoint = new Vector3(-11, 0, 0);
        allAliveEnemies = new List<GameObject>();
        //SkinnedMeshRenderer SMR = gameObject.GetComponent<SkinnedMeshRenderer>();
        CreateSoldier(SoldierType.Type0, StartingPoint);
    }

    void Update()
    {
    }



    public GameObject CreateSoldier(SoldierType soldierType, Vector2 position)
    {
        GameObject enemy = Instantiate(enemy0);

        enemy.name = "generated enemy " + soldierType.ToString();

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
