using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandlePlayButtonOnClickEvent()
    {
        SceneManager.LoadScene("WeaponChoose");
    }

    /// <summary>
	/// Handles the on click event from the high score button
	/// </summary>
	public void HandleHighScoreButtonOnClickEvent()
    {
        SceneManager.LoadScene("HighScore");
    }
    public void HandleQuitButtonOnClickEvent()
    {
        Application.Quit();
    }
}
