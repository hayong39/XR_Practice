using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class HW_VideoController : MonoBehaviour
{
    public VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player.Stop();
    }

    void VideoPlay()
    {
        player.Play();
    }

    void VideoStop()
    {
        player.Stop();
    }

    public void OnClick_Play()
    {
        VideoPlay();
    }

    public void OnClick_Stop()
    {
        VideoStop();
    }
}
