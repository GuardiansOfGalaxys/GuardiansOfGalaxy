using System.Collections;
using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization;
//using System.Xml;
using UnityEngine;

/// <summary>
/// Provides utility access to configuration data
/// </summary>
public static class ConfigurationUtils
{
	#region Fields

//	static ConfigurationData configurationData;

	#endregion

	#region Properties

	/// <summary>
	/// Gets the number of seconds in a game
	/// </summary>
	public static int TotalGameSeconds
    {
		get { return 60; }
	}


	/// <summary>
	/// Gets the min spawn delay for teddy bear spawning
	/// </summary>
	/// <value>minimum spawn delay</value>
	public static float MinSpawnDelay
    {
		get { return DifficultyUtils.MinSpawnDelay; }
	}

	/// <summary>
	/// Gets the max spawn delay for teddy bear spawning
	/// </summary>
	/// <value>maximum spawn delay</value>
	public static float MaxSpawnDelay
    {
		get { return DifficultyUtils.MaxSpawnDelay; }
	}
	

	/// <summary>
	/// Gets how many points a bear is worth
	/// </summary>
	/// <value>bear points</value>
	public static int BearPoints
    {
		get { return 10; }
	}

	public static float HealthEnemy1
    {
		get { return 10; }
	}
    public static float HealthEnemy2
    {
        get { return 20; }
    }
    public static float HealthEnemy3
    {
        get { return 30; }
    }

    #endregion

    #region Properties that should only be used by DifficultyUtils

    /// <summary>
    /// Gets the easy min spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy minimum spawn delay</value>
    public static float EasyMinSpawnDelay
    {
		get { return 2; }
	}

    /// <summary>
    /// Gets the medium min spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium minimum spawn delay</value>
    public static float MediumMinSpawnDelay
    {
		get { return 1f; }
	}

    /// <summary>
    /// Gets the hard min spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard minimum spawn delay</value>
    public static float HardMinSpawnDelay
    {
		get { return 0.5f; }
	}

    /// <summary>
    /// Gets the easy max spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>easy maximum spawn delay</value>
    public static float EasyMaxSpawnDelay
    {
		get { return 3; }
	}

    /// <summary>
    /// Gets the medium max spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>medium maximum spawn delay</value>
    public static float MediumMaxSpawnDelay
    {
		get { return 2; }
	}

    /// <summary>
    /// Gets the hard max spawn delay for teddy bear spawning
    /// This property should only be used by DifficultyUtils
    /// </summary>
    /// <value>hard maximum spawn delay</value>
    public static float HardMaxSpawnDelay
    {
		get { return 1; }
	}
 

    public static float HardSpeedEnemy1
    {
        get { return 5f; }
    }
    public static float MediumSpeedEnemy1
    {
        get { return 4f; }
    }
    public static float EasySpeedEnemy1
    {
        get { return 3f; }
    }

    public static float HardSpeedEnemy2
    {
        get { return 4f; }
    }
    public static float MediumSpeedEnemy2
    {
        get { return 3f; }
    }
    public static float EasySpeedEnemy2
    {
        get { return 2f; }
    }

    public static float HardSpeedEnemy3
    {
        get { return 3f; }
    }
    public static float MediumSpeedEnemy3
    {
        get { return 2f; }
    }
    public static float EasySpeedEnemy3
    {
        get { return 1f; }
    }

    public static float Enemy1Speed
    {
        get { return DifficultyUtils.SpeedEnemy1; }
    }
    public static float Enemy2Speed
    {
        get { return DifficultyUtils.SpeedEnemy2; }
    }
    public static float Enemy3Speed
    {
        get { return DifficultyUtils.SpeedEnemy3; }
    }

    public static int HardAttackEnemy1
    {
        get { return 3; }
    }
    public static int MediumAttackEnemy1
    {
        get { return 2; }
    }
    public static int EasyAttackEnemy1
    {
        get { return 1; }
    }

    public static int HardAttackEnemy2
    {
        get { return 4; }
    }
    public static int MediumAttackEnemy2
    {
        get { return 3; }
    }
    public static int EasyAttackEnemy2
    {
        get { return 2; }
    }

    public static int HardAttackEnemy3
    {
        get { return 5; }
    }
    public static int MediumAttackEnemy3
    {
        get { return 4; }
    }
    public static int EasyAttackEnemy3
    {
        get { return 3; }
    }

    public static int Enemy1Attack
    {
        get { return DifficultyUtils.AttackEnemy1; }
    }
    public static int Enemy2Attack
    {
        get { return DifficultyUtils.AttackEnemy2; }
    }
    public static int Enemy3Attack
    {
        get { return DifficultyUtils.AttackEnemy3; }
    }
    #endregion

    #region Public methods

    /// <summary>
    /// Initializes the configuration data by reading the data from an XML configuration file
    /// </summary>
    public static void Initialize()
    {		

	}


    #endregion
}
