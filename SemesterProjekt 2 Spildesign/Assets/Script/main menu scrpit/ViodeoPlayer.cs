using UnityEngine;
using UnityEngine.Video;

public class ViodeoPlayer : MonoBehaviour
{
    public VideoPlayer VideoPlayer;

    public double loopStartTime = 1.0;
    public double loopEndTime = 1.0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<VideoPlayer>();
   

        VideoPlayer.Play(); 
        VideoPlayer.isLooping = true;
    }

    // Update is called once per frame
    /*void Update()
    {
        if(VideoPlayer.isLooping=true)
        {
            
        }
    }*/
}
