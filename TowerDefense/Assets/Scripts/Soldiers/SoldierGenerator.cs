using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoldierGenerator : MonoBehaviour
{
    public GameObject enemy0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    public List<int> Waves = new List<int>();

    public float maxWaveTimer;
    public float WaveTimer;

    private string groundEnemiesTag = "GroundEnemies";
    private Vector3 StartingPoint;
    private int enemyCounter = 0;
    private int enemiesInWave = 5;

    public static int AliveEnemies = 0;

    void Start()
    {
        enemyCounter = 0;
        enemiesInWave = 5;
        maxWaveTimer = 10.0f;

        StartingPoint = new Vector3(-2, 0.25f, -5);

        
        WaveTimer = 0;

        InvokeRepeating("setAliveEnemies", 0f, 1f);
        int levelNumber = SceneManager.GetActiveScene().buildIndex - 1;
        SetLevelWaves(levelNumber);
    }

    public void setAliveEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(groundEnemiesTag);
        AliveEnemies = enemies.Length;
    }

    void Update()
    {

        if (AliveEnemies > 0)
        {
            return;
        }

        WaveTimer -= Time.deltaTime;

        if (enemyCounter >= Waves.Count)
        {
            GameManager.IsGameComplete = true;
            return;
        }

        if (WaveTimer <= 0f)
        {
            StartCoroutine(SpawnWave());
            WaveTimer = maxWaveTimer;
            return;
        }


    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < enemiesInWave; i++)
        {
            int soldier = Waves[enemyCounter];
            SoldierType soldierType = setSoldierType(soldier);
            CreateSoldier(soldierType, StartingPoint);
            enemyCounter++;
            yield return new WaitForSeconds(2f);
        }
        enemiesInWave++;
    }

    public void SetLevelWaves(int level)
    {
        if(level == 1)
        {
            Waves = PlayerStats.Level1Wave;
        }
        if (level == 2)
        {
            Waves = PlayerStats.Level2Wave;
        }
        if (level == 3)
        {
            Waves = PlayerStats.Level3Wave;
        }
        if (level == 4)
        {
            Waves = PlayerStats.Level4Wave;
        }
        if (level == 5)
        {
            Waves = PlayerStats.Level5Wave;
        }
        if (level == 6)
        {
            Waves = PlayerStats.Level6Wave;
        }
        if (level == 7)
        {
            Waves = PlayerStats.Level7Wave;
        }
        if (level == 8)
        {
            Waves = PlayerStats.Level8Wave;
        }
        if (level == 9)
        {
            Waves = PlayerStats.Level9Wave;
        }
        if (level == 10)
        {
            Waves = PlayerStats.Level10Wave;
        }
    }

    public SoldierType setSoldierType(int type)
    {
        if (type == 1)
        {
            return SoldierType.Type0;
        }
        if (type == 2)
        {
            return SoldierType.Type1;
        }
        if (type == 3)
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
