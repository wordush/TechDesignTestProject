using UnityEngine;
using UnityEngine.SceneManagement;

public class button_next_scene : MonoBehaviour
{
    public void SwitchScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "first_scene")
        {
            SceneManager.LoadScene("second_scene");
        }
        else if (currentSceneName == "second_scene")
        {
            SceneManager.LoadScene("first_scene");
        }
    }
}