using UnityEngine;
public class obstarcleMove : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        speed = 6.1f;
    }
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}