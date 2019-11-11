using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactive : MonoBehaviour
{
    private GameObject laser;
    public GameObject laserPrefab;
    public GameObject ExplosionPrefab;
    private Animation anim;
    private GameObject exp;
    public float delay;
    float time;


    void Start()
    {
        exp = ExplosionPrefab;
        anim = exp.GetComponent<Animation>();
        time = delay;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {


        if (other.gameObject.tag != "EL")
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

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime);

        if (time < 0)
        {
            laser = Instantiate(laserPrefab) as GameObject;
            laser.transform.position = transform.TransformPoint(Vector2.up * 5f);
            time = delay;
        }

        time -= Time.deltaTime;
    }
}
