using UnityEngine;

public class Speed : MonoBehaviour
{
    public int speedcnt;
    private void Start()
    {
        speedcnt = 1;
    }
    void Update()
    {
        UpSpeed();
    }
    void UpSpeed()
    {
        obstarcleMove wave = FindObjectOfType<obstarcleMove>();
        if(speedcnt == 0)
        {
            speedcnt++;
            wave.speed += 0.5f;

        }
    }
}