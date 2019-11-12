using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlls : MonoBehaviour
{
    public float speed = 10f;
    private float color;
    int heals = 10;
    bool skill;
    public GameObject slider;
    public GameObject Fill;
    public GameObject text;
    Rigidbody2D rb;
    private float ScreenWigth;

    void Start()
    {
        skill = false;
        rb = GetComponent<Rigidbody2D>();
        //ScreenWigth = Screen.width;
    }


    //void Update()
    //{
    //    if (Input.touchCount > 0)
    //    {
    //        if ((Input.GetTouch(0).pressure > 0.8f) != skill)
    //        {
    //            Skill();
    //        }

    //        if (Input.GetTouch(0).position.x > ScreenWigth / 2)
    //        {
    //            RunCharacter(1.0f);
    //        }
    //        if (Input.GetTouch(0).position.x < ScreenWigth / 2)
    //        {
    //            RunCharacter(-1.0f);
    //        }
    //    }
    //    else
    //    {
    //        rb.velocity = new Vector2(0, 0);

    //    }

    //    void RunCharacter(float horizontalInput)
    //    {

    //        //rb.AddForce(new Vector2(horizontalInput * speed * Time.deltaTime, 0));
    //        rb.velocity = new Vector2(horizontalInput * speed, 0);
    //    }
    //}


    private void FixedUpdate()
    {
#if UNITY_EDITOR
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 Move = new Vector2(h, v);
        rb.velocity = Move * speed;

        if ((Input.GetKey(KeyCode.Space)) != skill)
        {
            Skill();
        }
#endif
    }


    public void Skill()
    {
        if (skill == false)
        {
            Time.timeScale = 0.2f;
            skill = true;
            return;
        }

        if (skill == true)
        {
            Time.timeScale = 1f;
            skill = false;
            return;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "EnemyLaser")
        {
            heals--;
            color += 0.1f;
            Debug.Log(heals);
            slider.GetComponent<Slider>().value = heals;
            Fill.GetComponent<Image>().color = Color.Lerp(Color.green, Color.red, color);
        }
        if (heals <= 0)
        {
            Destroy(gameObject);
            text.SetActive(true);
            Fill.SetActive(false);
            Time.timeScale = 0.3f;
        }
    }
}