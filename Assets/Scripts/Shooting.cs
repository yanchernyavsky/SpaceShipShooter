using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private GameObject laser;
    public GameObject laserPrefab;
    public float delay;
    float time;
    void Start()
    {
        time = delay;   
    }

    // Update is called once per frame
    void Update()
    {
      
        if(time < 0)
        {
            laser = Instantiate(laserPrefab) as GameObject;
            laser.transform.position = transform.TransformPoint(Vector2.up*5f);
            time = delay;
        }

        time -= Time.deltaTime;
    }
}
