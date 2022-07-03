using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBotton : MonoBehaviour
{
    public void OnClickToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
