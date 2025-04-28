using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private string RetrySceneToLoad;
    [SerializeField] private string MainMenuScene;
    

    public void RetryButton()
    {
        SceneManager.LoadScene(RetrySceneToLoad);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MainMenuScene);
    }
}
