using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndBotton : MonoBehaviour
{
    private void Start()
    {
        
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
