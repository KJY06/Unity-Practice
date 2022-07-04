using UnityEngine;

public class SpownManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy;
    void SpawnEnemy()
    {
        float randomX = Random.Range(20, 30); //���� ��Ÿ�� X��ǥ�� �������� ������ �ݴϴ�.
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, -2.6f, 0f), Quaternion.identity); //������ ��ġ��, ȭ�� ���� ������ Enemy�� �ϳ� �������ݴϴ�.
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 3); //3���� ����, SpawnEnemy�Լ��� 1�ʸ��� �ݺ��ؼ� ���� ��ŵ�ϴ�.
    }
}