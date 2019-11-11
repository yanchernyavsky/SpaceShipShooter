using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public float speed = -10.0f;
    public float lifetime;
  


    private void Start()
    {
        lifetime = 5f;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag != "EN")
        {
        Destroy(gameObject);
            
        }
    }

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);

        lifetime -= Time.deltaTime;
        
        if (lifetime<=0)
        {
            Destroy(gameObject);
        }
    }

    public override bool Equals(object obj)
    {
        var laser = obj as EnemyLaser;
        return laser != null &&
               base.Equals(obj) &&
               speed == laser.speed &&
               lifetime == laser.lifetime;
    }
}
