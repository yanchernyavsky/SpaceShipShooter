using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private GameObject laser;
    public GameObject laserPrefab;
    public float delay;

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(delay);
        laser = Instantiate(laserPrefab) as GameObject;
        laser.transform.position = transform.TransformPoint(Vector2.up * 5f);
        StartCoroutine(Shoot());
    }
    void Start()
    {
        StartCoroutine(Shoot());
    }
}
