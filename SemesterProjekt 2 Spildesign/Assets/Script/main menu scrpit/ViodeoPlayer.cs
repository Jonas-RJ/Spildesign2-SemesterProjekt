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
        Invoke("videoreplay", 8);
    }

    // Update is called once per frame

    void Update()
    {
        
    }

    public void videoreplay()
    {
   
            
                VideoPlayer.Play();
                VideoPlayer.time = 4;
            

    }
}
