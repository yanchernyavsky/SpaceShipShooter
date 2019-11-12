using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactive : MonoBehaviour
{
    public GameObject ExplosionPrefab;
    private Animation anim;
    private GameObject exp;


    void Start()
    {
        exp = ExplosionPrefab;
        anim = exp.GetComponent<Animation>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "EnemyLaser")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            exp = Instantiate(ExplosionPrefab, transform.position, transform.rotation) as GameObject;
            exp.GetComponent<Animation>().Play("explosion");
            Destroy(gameObject);
        }

    }
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime);
    }
}
