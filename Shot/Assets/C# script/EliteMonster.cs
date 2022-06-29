using UnityEngine;
public class EliteMonster : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float hp = 2;
    void Update()
    {
        MoveToTarget();
    }
    public void MoveToTarget()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            hp -= 1;
            Destroy(collision.gameObject);
            if(hp <= 0)
            {
                Destroy(gameObject);
                Point point = FindObjectOfType<Point>();
                point.point += 2;
            }       
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}