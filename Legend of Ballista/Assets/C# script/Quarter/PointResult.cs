using UnityEngine;
using UnityEngine.UI;

public class PointResult : MonoBehaviour
{
    private int poiint;
    [SerializeField] private Text pointresult;
    private void Start()
    {
        Point pp = FindObjectOfType<Point>();
        poiint = pp.point;
        pointresult.text = $"Your Point : {poiint}";
    }
}
