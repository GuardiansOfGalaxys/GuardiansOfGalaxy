using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    private int index = 0;
    [SerializeField] GameObject[] characters;
    [SerializeField] TextMeshProUGUI characterName;
    [SerializeField] GameObject[] characterPrefabs;

    public static GameObject selectedCharater;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        selectCharacter();
    }

    public void OnPlayBtnClick()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        SceneManager.LoadScene("MenuLevelPlayer");
    }

    public void OnPreBtnClick()
    {
        
        if (index > 0) 
        {
        index--;
        }
        AudioManager.Play(AudioClipName.MenuButtonClick);
        selectCharacter();
    }

    public void OnNextBtnClick()
    {

        if (index < characters.Length -1)
        {
        index++;    
        }
        AudioManager.Play(AudioClipName.MenuButtonClick);
        selectCharacter();
    }
    private void selectCharacter()
    {
        for (int i =0; i < characters.Length; i++)
        {
            if (i == index)
            {
                characters[i].GetComponent<SpriteRenderer>().color= Color.white;
                selectedCharater = characterPrefabs[i];
                characterName.text = characterPrefabs[i].name;
            }
            else
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.black;
            }
        }
    }
    public void HandleBackButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        SceneManager.LoadScene("MainMenu");
    }
}
