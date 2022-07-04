using UnityEngine;

public class Player : MonoBehaviour
{
    public float jump = 6.4f;
    private bool forjump = true;
    public bool start;
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            if (forjump == true)
            {
                forjump = false;

                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
 
                start = true;
            }
        } 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            forjump = true;
        }
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("�΋Hħ");
        }
    }
}
