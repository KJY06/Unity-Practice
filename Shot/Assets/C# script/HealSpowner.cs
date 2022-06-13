using Unity.Mathematics;
using Random = UnityEngine.Random;
using UnityEngine;

public class HealSpowner : MonoBehaviour
{
    private Transform target;
    public GameObject Heal;
    private float realTime;
    [SerializeField] private float MaxTime;
    private void Start()
    {
        realTime = 0;
    }
    void Update()
    {
        realTime += Time.deltaTime;
        if (MaxTime <= realTime)
        {
            realTime = 0;
            RandomSelect();
        }
    }
    void RandomSelect()
    {
        target = GameObject.Find("player").transform;
        var vector3 = (Random.Range(0, 4)) switch
        {
            0 => new Vector2(target.position.x + 7f, target.position.y + Random.Range(-4f, 4f)),
            1 => new Vector2(target.position.x - 7f, target.position.y + Random.Range(-4f, 4f)),
            2 => new Vector2(target.position.x + Random.Range(-7f, 7f), target.position.y + 4),
            3 => new Vector2(target.position.x + Random.Range(-7f, 7f), target.position.y - 4),
            _ => Vector2.zero,
        };
        Instantiate(Heal, vector3, quaternion.identity);
    }
}
