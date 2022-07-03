using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Heal"))
        {
            Wall wall = FindObjectOfType<Wall>();
            wall.hp += 1;
            wall.Hp.text = $"Hp : {wall.hp}";
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
