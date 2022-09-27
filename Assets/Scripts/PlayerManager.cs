using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    public static bool levelStarted;
    public static bool gameOver;

    public GameObject StartMenuPanel;
    public GameObject gameOverPanel;

    public static int gems;
    public TextMeshProUGUI gemsText;

   
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.Play("Background");
        gems = 0;
        gameOver = levelStarted = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        gemsText.text = (PlayerPrefs.GetInt("TotalGems",0) +gems).ToString();
       /* Touchscreen ts =Touchscreen.current;
        if(ts != null && ts.primaryTouch.press.isPressed && !levelStarted == true){
            levelStarted = true;
            StartMenuPanel.SetActive(false);
             AudioManager.instance.Play("Start");
        }*/
        if(gameOver){
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            PlayerPrefs.SetInt("TotalGems",PlayerPrefs.GetInt("TotalGems",0) +gems);
            this.enabled = false;
        }
    }
    
}
