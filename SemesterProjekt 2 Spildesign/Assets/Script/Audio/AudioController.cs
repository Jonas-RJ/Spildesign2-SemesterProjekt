using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource cutSceneMusic;

    public void StartCutSceneMusic()
    {
        cutSceneMusic.Play();
    }

    public void StopCutSceneMusic()
    {
        cutSceneMusic.Stop();
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
