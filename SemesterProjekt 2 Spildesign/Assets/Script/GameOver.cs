using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private string RetrySceneToLoad;
    [SerializeField] private string MainMenuScene;
    

    public void RetryButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(RetrySceneToLoad);
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(MainMenuScene);
    }
}
