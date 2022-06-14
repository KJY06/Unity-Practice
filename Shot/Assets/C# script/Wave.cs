using UnityEngine;
using UnityEngine.UI;

public class Wave : MonoBehaviour
{
    public int wave;
    [SerializeField] private Text Waave;
    public int wavecnt = 1;
    [SerializeField] private Point point = FindObjectOfType<Point>();
    void Start()
    {
        wave = 1;
        Waave.text = $"Wave : {wave}";
    }
    void Update()
    {
        if(point.point % 100 >= 0 && point.point != 0 && wavecnt == 0)
        {
            wavecnt++;
            wave++;
            Waave.text = $"Wave : {wave}";
        }
    }
}
