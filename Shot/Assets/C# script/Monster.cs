using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed;
    public Vector2 direction;

    // Update is called once per frame
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
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}