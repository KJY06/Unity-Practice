using Unity.Mathematics;
using Random = UnityEngine.Random;
using UnityEngine;

public class generate : MonoBehaviour
{
    private Transform target;
    public GameObject Monster;
    public GameObject Elite;
    public GameObject Boss;

    private float Mcurrenttime;
    public float Mmaxtime;
    private float Ecurrenttime;
    public float Emaxtime;
    public bool forspon = false;
    public int bosscnt = 0;

    private void Start()
    {
        Mcurrenttime = 0;
        Ecurrenttime = 0;
    }
    void Update()
    {
        Spon();

        forspon = false;
    }
    void Spon()
    {

        RandomSelect();
    }
    void RandomSelect()
    {
        Mcurrenttime += Time.deltaTime;
        Ecurrenttime += Time.deltaTime;
        if (Mcurrenttime >= Mmaxtime)
        {
            Mcurrenttime = 0;
            target = GameObject.Find("player").transform;
            var vector2 = new Vector2(target.position.x - 20f, target.position.y + Random.Range(-4.4f, 4.4f));
            Instantiate(Monster, vector2, quaternion.identity);

        }

        if (Ecurrenttime >= Emaxtime)
        {
            Ecurrenttime = 0;
            target = GameObject.Find("player").transform;
            var vector2 = new Vector2(target.position.x - 20f, target.position.y + Random.Range(-4.4f, 4.4f));
            Instantiate(Elite, vector2, quaternion.identity);
        }

        if (forspon == true && bosscnt == 0)
        {
            bosscnt++;
            forspon = false;
            target = GameObject.Find("player").transform;
            var vector2 = new Vector2(target.position.x - 20f, target.position.y + Random.Range(-4.4f, 4.4f));
            Instantiate(Boss, vector2, quaternion.identity);
        }
    }
}

