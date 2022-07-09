using UnityEngine;

public class floormove : MonoBehaviour
{
    public Sprite[] sprite = new Sprite[2];
    private SpriteRenderer moving;
    private float currenttime;
    void Update()
    {
        Move();
    }

    private void Move()
    {
        currenttime = Time.deltaTime;

        if (currenttime >= 0.1f)
        {
            moving.sprite = sprite[1];
            currenttime = 0;
        }
        moving.sprite = sprite[0];
    }
}
