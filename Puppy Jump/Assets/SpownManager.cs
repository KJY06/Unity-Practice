using UnityEngine;

public class SpownManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy;
    void SpawnEnemy()
    {
        float randomX = Random.Range(20, 30); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, -2.6f, 0f), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 3); //3초후 부터, SpawnEnemy함수를 1초마다 반복해서 실행 시킵니다.
    }
}