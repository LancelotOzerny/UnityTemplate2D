using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void OpenByIndex(int index)
    {
        if (SceneManager.sceneCountInBuildSettings <= index)
        {
            Debug.LogWarning($"You try open scene { index }. Check this index in BuildSettings!");
            return;
        }

        SceneManager.LoadScene(index);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
