using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject EnemyPrefab;
    GameObject enemy;
    float timer;
    float delay = 1f;

    private void Start()
    { 

    }

    void Update()
    {
        if (timer < 0)
        {
            enemy = Instantiate(EnemyPrefab, new Vector2(Random.Range(-2.2f, 2.2f), 6f), Quaternion.Euler(0f, 0f, 180f));
            timer = delay;
        }
        timer -= Time.deltaTime;
    }

}
