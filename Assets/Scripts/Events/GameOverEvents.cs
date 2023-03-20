using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public void HandleBackButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        SceneManager.LoadScene("MainMenu");
    }
}
