using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject enemy;
    public int maxEnemies = 15;

    private int numEnemies;
    private Vector3[] spawnPositions = new Vector3[6];
    private float spawnCd;

    void Start()
    {

        spawnPositions[0] = new Vector3(10f, -4f, 0f);
        spawnPositions[1] = new Vector3(-10f, -4f, 0f);
        spawnPositions[2] = new Vector3(-0.75f, -3.5f, 0f);
        spawnPositions[3] = new Vector3(-7.65f, -3.5f, 0f);
        spawnPositions[4] = new Vector3(-5.5f, -3.5f, 0f);
        spawnPositions[5] = new Vector3(3.5f, -3.5f, 0f);

        spawnCd = 2f;

        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemy, spawnPositions[Random.Range(0, 4)], Quaternion.identity);
        }
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        spawnCd -= Time.deltaTime;
        if (spawnCd <= 0f)
        {
            numEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
            if (numEnemies < maxEnemies)
            {
                Instantiate(enemy, spawnPositions[Random.Range(0, 4)], Quaternion.identity);
            }
            spawnCd = 2f;
        }
    }
}