using UnityEngine;
using UnityEngine.Video;

public class ViodeoPlayer : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<VideoPlayer>();
        VideoPlayer.Play();

    }

    // Update is called once per frame
    void Update()
    {
        //videoreplay();
    }

    /*public void videoreplay()
    {
        if (VideoPlayer.loopPointReached) 
        {
            if (!VideoPlayer.isPlaying)
            {
                VideoPlayer.Play();
                VideoPlayer.time = 4;

            }
        }
        
    }*/
}
