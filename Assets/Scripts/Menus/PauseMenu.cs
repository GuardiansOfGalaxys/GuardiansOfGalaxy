using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenu;
    [SerializeField]
    Text timerText;

    public static bool isGamePaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            AudioManager.Play(AudioClipName.MenuButtonClick);
            Debug.Log("Escape");
            if(isGamePaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused= true;
        //Debug.Log("Pause");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused= false;
        //Debug.Log("Resume");
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        AudioManager.Play(AudioClipName.MenuButtonClick);
        SceneManager.LoadScene(sceneID);
        //Debug.Log("Home");
    }

    public void Next()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        MainPlayScreenHUD tec = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MainPlayScreenHUD>();
        tec.gameTimer.Run();
        //for (int i = 10; i >= 0; i--)
        //{
        //    timerText.text = i.ToString();

        //}

    }

}
