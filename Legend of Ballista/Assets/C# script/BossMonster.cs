using UnityEngine;
using UnityEngine.UI;
public class BossMonster : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed;
    public Vector2 direction;
    [SerializeField] private float monsterhp = 7;

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
            monsterhp -= 1;
            Destroy(collision.gameObject);
            if (monsterhp <= 0)
            {
                Wave wavve = FindObjectOfType<Wave>();
                wavve.wave++;
                Point ppoint = FindObjectOfType<Point>();
                ppoint.point += 10;
            }
            if (monsterhp <= 0)
            {
                Destroy(gameObject);
            }
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
