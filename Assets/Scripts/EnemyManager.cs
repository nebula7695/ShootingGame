using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    float maxTime=2.5f;
    float minTime = 0.7f;
    private float currentTime = 0;
    private float createTime = 1f;
    private void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;
            currentTime = 0;
        }
        
    }
}
