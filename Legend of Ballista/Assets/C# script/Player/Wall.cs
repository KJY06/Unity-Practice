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
        CameraShake shake = FindObjectOfType<CameraShake>();

        if (collision.CompareTag("Monster"))
        {
            hp -= 1;
            Hp.text = $"Hp : {hp}";
            shake.shakeCnt = 0;
        }
        if (collision.CompareTag("Boss"))
        {
            hp -= 5;
            Hp.text = $"Hp : {hp}";
            shake.shakeCnt = 0;
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}