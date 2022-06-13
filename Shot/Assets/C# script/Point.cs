using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public int point;
    [SerializeField] private Text Pooint; 
    void Start()
    {
        point = 0;
        Pooint.text = $"Point : {point}";
    }
    void Update()
    {
        Pooint.text = $"Point : {point}";
        if(point % 100 == 0 && point != 0)
        {
            BossSpowner spon = FindObjectOfType<BossSpowner>();
            spon.forspon = spon;
        }
    }
}
