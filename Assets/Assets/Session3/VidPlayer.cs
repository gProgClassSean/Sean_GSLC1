using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VidPlayer : MonoBehaviour
{
    private VideoPlayer _vid;

    private void Awake()
    {
        _vid = GetComponent<VideoPlayer>();
    }

    public void PlayVid()
    {
        _vid.Play();
    }

    private void OnEnable()
    {
        _vid.loopPointReached += BackToMenu;
    }

    private void OnDisable()
    {
        _vid.loopPointReached -= BackToMenu;
    }

    public void BackToMenu(UnityEngine.Video.VideoPlayer vp)
    {
        SceneHandler.GoToMainMenu();
    }

}
