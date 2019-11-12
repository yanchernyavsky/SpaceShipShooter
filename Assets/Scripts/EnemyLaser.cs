using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public float speed = -10.0f;
    public float lifetime;
  
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag != "Enemy")
        {
            Destroy(gameObject); 
        }
    }

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        Destroy(gameObject, lifetime);
    }
}
