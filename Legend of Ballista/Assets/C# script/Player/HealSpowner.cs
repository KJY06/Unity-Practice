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
        var vector2 = new Vector2(target.position.x + Random.Range(-18f, -10f), target.position.y + Random.Range(-4.4f, 4.4f));
        Instantiate(Heal, vector2, quaternion.identity);
    }
}
