using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMain : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
