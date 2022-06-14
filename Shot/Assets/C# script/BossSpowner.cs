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
            var vector3 = (Random.Range(0, 4)) switch
            {
                0 => new Vector2(target.position.x + 9.5f, target.position.y + Random.Range(-5.5f, 5.5f)),
                1 => new Vector2(target.position.x - 9.5f, target.position.y + Random.Range(-5.5f, 5.5f)),
                2 => new Vector2(target.position.x + Random.Range(-9.5f, 9.5f), target.position.y + 5),
                3 => new Vector2(target.position.x + Random.Range(-9.5f, 9.5f), target.position.y - 5),
                _ => Vector2.zero,
            };
            Instantiate(enemy, vector3, quaternion.identity);
        }
    }
}
