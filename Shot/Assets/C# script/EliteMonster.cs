using UnityEngine;
public class EliteMonster : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed;
    public Vector2 direction;
    [SerializeField] private float hp = 2;
    void Update()
    {
        MoveToTarget();
    }
    public void MoveToTarget()
    {
        target = GameObject.Find("player").transform;
        direction = target.position - transform.position;
        direction.Normalize();
        transform.Translate(new Vector3(target.position.x + direction.x, target.position.y + direction.y) * speed * Time.deltaTime);
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