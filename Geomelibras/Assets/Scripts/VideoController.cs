using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject videoDisplay;
    //public GameObject background;

    public VideoClip clip1;
    public VideoClip clip2;
    public VideoClip clip3;
    public VideoClip clip4;

    private void ReproduzirClip(VideoClip clip)
    {
        videoPlayer.Stop();

        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = clip;

        //background.SetActive(true);
        videoDisplay.SetActive(true);

        videoPlayer.Play();
    }

    // Métodos para os botões

    public void ReproduzirVideo1()
    {
        ReproduzirClip(clip1);
    }

    public void ReproduzirVideo2()
    {
        ReproduzirClip(clip2);
    }

    public void ReproduzirVideo3()
    {
        ReproduzirClip(clip3);
    }

    public void ReproduzirVideo4()
    {
        ReproduzirClip(clip4);
    }

    public void FecharVideo()
    {
        videoPlayer.Stop();

        videoDisplay.SetActive(false);
        //background.SetActive(false);
    }
}