using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public int point;
    public int pointcnt = 0;
    [SerializeField] private Text Pooint;
    void Start()
    {
        DontDestroyOnLoad(this);
        point = 0;
        Pooint.text = $"Point : {point}";
    }
    void Update()
    {
        Pooint.text = $"Point : {point}";
        if(point % 100 == 0 && point != 0&&pointcnt == 0)
        {
            generate spon = FindObjectOfType<generate>();
            spon.forspon = true;
            spon.bosscnt = 0;
            pointcnt++;
            
        }
    }
}
