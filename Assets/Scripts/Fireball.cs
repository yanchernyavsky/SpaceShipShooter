using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 15.0f;
    public float lifetime;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        Destroy(gameObject, lifetime);
    }
}
