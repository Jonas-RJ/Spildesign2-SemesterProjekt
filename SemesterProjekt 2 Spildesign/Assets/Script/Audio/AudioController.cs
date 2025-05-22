using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public AudioSource cutSceneMusic;

    public AudioSource ambientMusic;

    public AudioSource winningMusic;

    public void StartCutSceneMusic()
    {
        cutSceneMusic.Play();
    }

    public void StopCutSceneMusic()
    {
        cutSceneMusic.Stop();
    }

    public void StartAmbientMusic()
    {
        ambientMusic.Play();
    }

    public void StopAmbientMusic()
    {
        ambientMusic.Stop();
    }

    public void StartWinningMusic()
    {
        winningMusic.Play();
    }

    public void StopWinningMusic()
    {
        winningMusic.Stop();
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Map")
        {
            ambientMusic.Play();
        }

        if (SceneManager.GetActiveScene().name == "GameOverScene")
        {
            ambientMusic.Stop();
            winningMusic.Play();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
