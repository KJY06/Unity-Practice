using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndBotton : MonoBehaviour
{
    private int poiint;
    [SerializeField] private Text pointresult;
    private void Start()
    {
        Point pp = FindObjectOfType<Point>();
        poiint = pp.point;
        pointresult.text = $"Your Point : {poiint}";
    }
    public void OnCLick()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnCLickExit()
    {
        Application.Quit();
    }
}
