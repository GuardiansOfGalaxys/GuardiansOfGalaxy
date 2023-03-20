using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

/// <summary>
/// Provides difficulty-specific utilities
/// </summary>
public static class DifficultyUtils
{
	#region Fields

	static Difficulty difficulty;

	#endregion

	#region Properties

	/// <summary>
	/// Gets the min spawn delay for teddy bear spawning
	/// </summary>
	/// <value>minimum spawn delay</value>
	public static float MinSpawnDelay
    {
		get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasyMinSpawnDelay;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumMinSpawnDelay;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardMinSpawnDelay;
                default:
                    return ConfigurationUtils.EasyMinSpawnDelay;
            }
		}
	}

	/// <summary>
	/// Gets the max spawn delay for teddy bear spawning
	/// </summary>
	/// <value>maximum spawn delay</value>
	public static float MaxSpawnDelay
    {
		get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasyMaxSpawnDelay;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumMaxSpawnDelay;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardMaxSpawnDelay;
                default:
                    return ConfigurationUtils.EasyMaxSpawnDelay;
            }
		}
	}


	/// <summary>
	/// Gets the maximum delay for a teddy bear to shoot
	/// a teddy bear projectile
	/// </summary>
	/// <value>bear maximum shot delay</value>
	public static float SpeedEnemy1
    {
		get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasySpeedEnemy1;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumSpeedEnemy1;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardSpeedEnemy1;
                default:
                    return ConfigurationUtils.EasySpeedEnemy1;
            }
		}
	}

    public static float SpeedEnemy2
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasySpeedEnemy2;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumSpeedEnemy2;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardSpeedEnemy2;
                default:
                    return ConfigurationUtils.EasySpeedEnemy2;
            }
        }
    }

    public static float SpeedEnemy3
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasySpeedEnemy3;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumSpeedEnemy3;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardSpeedEnemy3;
                default:
                    return ConfigurationUtils.EasySpeedEnemy3;
            }
        }
    }

    public static int AttackEnemy1
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasyAttackEnemy1;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumAttackEnemy1;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardAttackEnemy1;
                default:
                    return ConfigurationUtils.EasyAttackEnemy1;
            }
        }
    }

    public static int AttackEnemy2
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasyAttackEnemy2;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumAttackEnemy2;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardAttackEnemy2;
                default:
                    return ConfigurationUtils.EasyAttackEnemy2;
            }
        }
    }

    public static int AttackEnemy3
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasyAttackEnemy3;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumAttackEnemy3;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardAttackEnemy3;
                default:
                    return ConfigurationUtils.EasyAttackEnemy3;
            }
        }
    }

    #endregion

    #region Public methods

    /// <summary>
    /// Initializes the difficulty utils
    /// </summary>
    public static void Initialize()
    {
		EventManager.AddListener(EventName.GameStartedEvent,
			HandleGameStartedEvent);
	}


	#endregion

	#region Private methods

	/// <summary>
	/// Sets the difficulty and starts the game
	/// </summary>
	/// <param name="intDifficulty">int value for difficulty</param>
	static void HandleGameStartedEvent(int intDifficulty)
    {
		difficulty = (Difficulty)intDifficulty;
		SceneManager.LoadScene("GamePlay");
	}

	#endregion
}
