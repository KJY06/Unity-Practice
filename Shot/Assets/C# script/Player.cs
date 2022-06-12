using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private int hp;
    public Text Hp;
    void Start()
    {
        Hp.text = $"Hp : {hp}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Monster"))
        {
            hp -= 1;
            Hp.text = $"Hp : {hp}";
            if(hp <= 0)
            {
                SceneManager.LoadScene("End");
            }
        }
    }
}
