using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class MainPlayScreenHUD : IntEventInvoker
{
   public Timer gameTimer;

    // high score menu support
    [SerializeField]
    GameObject hud;
    
    /// <summary>
    /// Awake is called before Start
    /// </summary>
    void Awake()
    {
        // create and start game timer
        gameTimer = gameObject.AddComponent<Timer>();
        //gameTimer.AddTimerFinishedEventListener(HandleGameTimerFinishedEvent);
        gameTimer.Duration = 60;
        gameTimer.Run();

        // add self as timer changed event invoker
        unityEvents.Add(EventName.TimerChangedEvent, gameTimer.TimerChangedEvent);
        EventManager.AddInvoker(EventName.TimerChangedEvent, this);

        // add listener for game over event
        //EventManager.AddListener(EventName.GameOverEvent, HandleGameOverEvent);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Handles the game timer finished event
    /// </summary>
    void HandleGameTimerFinishedEvent()
    {
        EndGame();
    }

    /// <summary>
    /// Handles the game over event
    /// </summary>
    /// <param name="unused">unused</param>
    void HandleGameOverEvent(int unused)
    {
        EndGame();
    }

    /// <summary>
    /// Ends the game
    /// </summary>
    void EndGame()
    {
    }
}
