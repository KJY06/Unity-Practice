
using Unity.Mathematics;
using Random = UnityEngine.Random;
using UnityEngine;

public class Spowner : MonoBehaviour
{
    private Transform target;
    public GameObject enemy;
    private float realTime, randomx, randomy;
    public float MaxTime;

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
        var vector2 = new Vector2(target.position.x - 20f, target.position.y + Random.Range(-5f, 5f));
        Instantiate(enemy, vector2, quaternion.identity);
    }
}
