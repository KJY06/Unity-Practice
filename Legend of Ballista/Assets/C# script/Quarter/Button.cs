using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public void OnClickToManual()
    {
        SceneManager.LoadScene("Rule");
    }
    public void OnClickToMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnCLickReturnToMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnCLickToExit()
    {
        Application.Quit();
    }
}
