using UnityEngine;

public class SpownManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy;
    public GameObject LEnemy;
    public GameObject AEnemy;
    public GameObject LAEnemy;
    void SpawnEnemy()
    {
        int spawn = Random.Range(0, 4);
        float randomX = Random.Range(20, 30); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        if (enableSpawn)
        {
            if(spawn == 0)
            {
                GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, -2.8f, 0f), Quaternion.identity);
            }
            else if (spawn == 1)
            {
                GameObject enemy = (GameObject)Instantiate(LEnemy, new Vector3(randomX, -2.5f, 0f), Quaternion.identity);
            }
            else if (spawn == 2)
            {
                GameObject enemy = (GameObject)Instantiate(AEnemy, new Vector3(randomX, -0.7f, 0f), Quaternion.identity);
            }
            else if (spawn == 3)
            {
                GameObject enemy = (GameObject)Instantiate(LAEnemy, new Vector3(randomX, -2, 0f), Quaternion.identity);
            }
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 2.4f); //3초후 부터, SpawnEnemy함수를 1초마다 반복해서 실행 시킵니다.
    }
}