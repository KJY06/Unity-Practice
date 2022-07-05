using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    private float currentTime;
    private float maxTime;
    private Speed wave;
    public int point;
    [SerializeField] Text PointText;

    private void Start()
    {
        wave = GameObject.FindObjectOfType<Speed>();
        maxTime = 0.1f;
        point = 0;
        PointText.text = $"{point}";
    }
    private void Update()
    {
        AddPoint();
    }
    void AddPoint()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            currentTime = 0;
            point += 1;
            PointText.text = $"{point}";
        }
        if(point % 100 ==0 && point >= 200)
        {
            wave.speedcnt = 0;
        }
    }
}
