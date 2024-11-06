using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class gameMamagerVideoPlayer : MonoBehaviour
{
    [SerializeField] public VideoPlayer videoPlayer;
    [SerializeField] public GameObject Screen;
    [SerializeField] public GameObject howToPlay;
    [SerializeField] public GameObject levelSelect;
    [SerializeField] public GameObject endlSelect; 
    [SerializeField] private GameObject Video;
    [SerializeField] private GameObject buttonSkip;
    [SerializeField] private string ClipName;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.url = System.IO.Path.Combine (Application.streamingAssetsPath,""+ClipName); 
        videoPlayer.Play();
        Video.SetActive(true);
    }

    private void Update()
    {
        buttonSkip.SetActive(true);
        if (videoPlayer.isPaused)
        {
            Debug.Log("Destroy");
            howToPlay.SetActive(true);
            levelSelect.SetActive(true); // SetActive(true) ด่านแรก
            endlSelect.SetActive(true);
            Destroy(Video);
            videoPlayer.Stop();
            Screen.gameObject.SetActive(false);
            buttonSkip.SetActive(false);
        }
    }

    public void playSkip()
    {
        howToPlay.SetActive(true);
        levelSelect.SetActive(true);
        endlSelect.SetActive(true);
        Destroy(Video);
        videoPlayer.Stop();
        Screen.gameObject.SetActive(false);
        buttonSkip.SetActive(false);
    }
}
