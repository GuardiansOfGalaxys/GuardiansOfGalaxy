using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitDifficulty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DifficultyUtils.Initialize();
        ConfigurationUtils.Initialize();
    }

}
