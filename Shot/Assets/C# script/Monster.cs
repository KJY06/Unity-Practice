using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float speed;
    public Vector2 direction;
    public int rotateSpeed;
    private void Start()
    {
        target = GameObject.Find("player").transform;
        direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion angleAxis = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
        Quaternion rotation = Quaternion.Slerp(transform.rotation, angleAxis, rotateSpeed * Time.deltaTime);
        transform.rotation = rotation;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
        
    }

    public void MoveToTarget()
    {

        direction = target.position - transform.position;
        direction.Normalize();
        transform.Translate(new Vector3(target.position.x + direction.x, target.position.y + direction.y) * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Point point = FindObjectOfType<Point>();
            point.point += 1;
            point.pointcnt = 0;
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}