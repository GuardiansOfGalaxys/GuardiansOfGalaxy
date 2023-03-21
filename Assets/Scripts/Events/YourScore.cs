using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class YourScore : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {

        GetScorePlayer();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void GetScorePlayer()
    {
        scoreText.text = $"Your score: {PlayerPrefs.GetInt("ScorePlayer", 0)}";
    }
}
