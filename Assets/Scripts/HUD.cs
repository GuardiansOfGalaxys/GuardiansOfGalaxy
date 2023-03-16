using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// The HUD for the game
/// </summary>
public class HUD : MonoBehaviour
{
	#region Fields

	// score support
	[SerializeField]
	Text scoreText;
	int score = 0;

	// health support
	[SerializeField]
	Slider healthBar;

	// timer support
	[SerializeField]
	Text timerText;

	GameObject player;
	Character character;

	private int currentHealth;
    #endregion

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
		// add listener for PointsAddedEvent
		EventManager.AddListener(EventName.PointsAddedEvent, HandlePointsAddedEvent);

		// initialize score text
		scoreText.text = "Score: " + score;


		// add listener for TimerChangedEvent and initialize timer text
		EventManager.AddListener(EventName.TimerChangedEvent, HandleTimerChangedEvent);
		timerText.text = "60";

      
        player = CharacterSelect.selectedCharater;
		if (player.name == "HeroGun")
		{
            character = new HeroGun(player);
            healthBar.maxValue = character.health;
		}
        if (player.name == "HeroSword")
        {
            character = new HeroSword(player);
            healthBar.maxValue = character.health;
        }

        currentHealth = (int) healthBar.maxValue;
    }

	#region Properties

	/// <summary>
	/// Gets the score
	/// </summary>
	/// <value>the score</value>
	public int Score
    {
		get { return score; }
	}

	#endregion

	#region Private methods

	/// <summary>
	/// Handles the points added event by updating the displayed score
	/// </summary>
	/// <param name="points">points to add</param>
	private void HandlePointsAddedEvent(int points)
    {
		score += points;
		scoreText.text = "Score: " + score;
	}

	/// <summary>
	/// Handles the health changed event by changing
	/// the health bar value
	/// </summary>
	/// <param name="value">health value</param>
	public void HandleHealthChangedEvent(int value)
    {
		
        healthBar.value = currentHealth - value;
		currentHealth = (int) healthBar.value;
        if (healthBar.value == 0)
		{
			//Destroy(player);
			SetHighScore();
            SceneManager.LoadScene("EndGame");
        }
		
	}

    void SetHighScore()
    {

        int currentScore = Score;
        if (PlayerPrefs.HasKey("High Score"))
        {
            if (currentScore > PlayerPrefs.GetInt("High Score", 0))
            {
                PlayerPrefs.SetInt("High Score", currentScore);
                PlayerPrefs.Save();
            }
        }
        else
        {
            PlayerPrefs.SetInt("High Score", currentScore);
            PlayerPrefs.Save();
        }
    }
    /// <summary>
    /// Handles the timer changed event by updating the displayed timer
    /// </summary>
    /// <param name="value">timer value</param>
    void HandleTimerChangedEvent(int value)
    {
		timerText.text = value.ToString();
	}

    #endregion
}
