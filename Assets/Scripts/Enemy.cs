using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject EnemyPrefab;
    GameObject enemy;
    public float delay;

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(delay);
        enemy = Instantiate(EnemyPrefab, new Vector2(Random.Range(-2.2f, 2.2f), 6f), Quaternion.Euler(0f, 0f, 180f));
        StartCoroutine(Spawn());
    }

    void Start()
    {
        StartCoroutine(Spawn());
    }

}
