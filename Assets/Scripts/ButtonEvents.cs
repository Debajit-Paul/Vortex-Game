using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.Audio;


public class ButtonEvents : MonoBehaviour
{
    public static bool levelStarted;
    public GameObject StartMenuPanel;
    public Slider volumeSlider;
    public AudioMixer mixer;
    private float value;

    void Start()
    {    
        levelStarted = false;
        mixer.GetFloat("volume",out value);
        volumeSlider.value = value;
    }

    public void SetVolume()
    {
        mixer.SetFloat("volume",volumeSlider.value);    
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }

    public void start()
    {
        levelStarted = true;
        StartMenuPanel.SetActive(false);
        AudioManager.instance.Play("Start");
    }
}
