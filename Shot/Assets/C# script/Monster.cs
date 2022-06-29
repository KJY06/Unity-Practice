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
        
    }

    // Update is called once per frame
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