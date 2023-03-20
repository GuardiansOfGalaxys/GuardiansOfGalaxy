using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        GetHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void GetHighScore()
    {
        highScoreText.text = $"High Score: {PlayerPrefs.GetInt("High Score", 0)}";
    }
}
