using UnityEngine;
using UnityEngine.UI;

public class Wave : MonoBehaviour
{
    public int wave;
    [SerializeField] private Text Waave;
    public int wavecnt = 0;
    private int currentwave;
    void Start()
    {
        wave = 0;
        Waave.text = $"Wave : {wave}";
        currentwave = wave;
    }
    void Update()
    {
       if (currentwave != wave)
        {
            currentwave = wave;
            Spowner spon = FindObjectOfType<Spowner>();
            spon.MaxTime -= 0.05f;
        }
        Waave.text = $"Wave : {wave}";
    }
}
