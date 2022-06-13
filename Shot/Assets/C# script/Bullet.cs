using System.Collections;
using System.Collections.Generic;
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
            Player player = FindObjectOfType<Player>();
            player.hp += 1;
            player.Hp.text = $"Hp : {player.hp}";
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
