using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDamaged : MonoBehaviour
{
    public Sprite[] sprite = new Sprite[4];
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        ChangeSprite();
    }
    void ChangeSprite()
    {

        Wall wall = FindObjectOfType<Wall>();
        if(wall.hp > 3)
        {
            spriteRenderer.sprite = sprite[0];
        }
        if(wall.hp == 3)
        {
            spriteRenderer.sprite = sprite[1];
        }
        if (wall.hp == 2)
        {
            spriteRenderer.sprite = sprite[2];
        }
        if (wall.hp == 1)
        {
            spriteRenderer.sprite = sprite[3];
        }
    }
}
