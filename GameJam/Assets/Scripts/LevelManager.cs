using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public int maxEnemies = 6;
    public int scorePoints = 0;
    public float gameTime;
    public GameObject[] enemyInv = new GameObject[7];

    public Text timer;
    public Text score; 

    private int numEnemies;
    private float spawnCd;
    private Vector3[] spawnPos = new Vector3[6];
    
    

    void Start()
    {
        PlayerData.Score = 0;

        spawnPos[0] = new Vector3(10f, -4f, 0f);
        spawnPos[1] = new Vector3(-10f, -4f, 0f);
        spawnPos[2] = new Vector3(-0.75f, -3.5f, 0f);
        spawnPos[3] = new Vector3(-7.65f, -3.5f, 0f);
        spawnPos[4] = new Vector3(-5.5f, -3.5f, 0f);
        spawnPos[5] = new Vector3(3.5f, -3.5f, 0f);

        spawnCd = 1f;

        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyInv[Random.Range(0,7)], spawnPos[Random.Range(0, 6)], Quaternion.identity);
        }

        
    }

    void Awake()
    {
        gameTime = 150f;
    }

    void FixedUpdate()
    {
        gameTime -= Time.deltaTime;

        timer.text = string.Format("Time: {0:00}:{1:00}", (int)gameTime / 60, (int)gameTime % 60);

        score.text = ("Score: " + scorePoints);

        spawnCd -= Time.deltaTime;

        if (spawnCd <= 0f)
        {
            numEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
            if (numEnemies < maxEnemies)
            {
                Instantiate(enemyInv[Random.Range(0, 7)], spawnPos[Random.Range(0, 6)], Quaternion.identity);
            }
            spawnCd = 2f;
        }

        PlayerData.Score = scorePoints;

        if (gameTime <= 0f) SceneManager.LoadScene("End");
    }
}