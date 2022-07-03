using Unity.Mathematics;
using Random = UnityEngine.Random;
using UnityEngine;
public class BossSpowner : MonoBehaviour
{
    private Transform target;
    public GameObject enemy;
    public bool forspon = false;
    public int bosscnt = 0;
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

        if(forspon == true && bosscnt == 0)
        {
            bosscnt++;
            forspon = false;
            target = GameObject.Find("player").transform;
            var vector2 = new Vector2(target.position.x - 20f, target.position.y + Random.Range(-5f, 5f));
            Instantiate(enemy, vector2, quaternion.identity);
        }
    }
}
