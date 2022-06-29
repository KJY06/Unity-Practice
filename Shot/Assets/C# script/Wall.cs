using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
    public int hp;
    public Text Hp;
    void Start()
    {
        Hp.text = $"Hp : {hp}";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            hp -= 1;
            Hp.text = $"Hp : {hp}";
        }
        if (collision.CompareTag("Boss"))
        {
            hp -= 5;
            Hp.text = $"Hp : {hp}";
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}