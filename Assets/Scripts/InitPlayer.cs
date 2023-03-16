using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class InitPlayer : MonoBehaviour
{
    public static Character player;
    [SerializeField]
    public Camera camera;
    public GameObject mapController;
    public GameObject itemController;
    private float timer = 0f;
    private bool timerStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject selectedCharater = CharacterSelect.selectedCharater;
        GameObject playerObject = Instantiate(selectedCharater, new Vector3(0,0,0), Quaternion.identity);
        playerObject.name = "Player";

        switch (selectedCharater.name)
        {
            case "HeroSword":
                player = new HeroSword(playerObject)
                {
                    camera = camera,
                    mapController = mapController.GetComponent<MapController>(),
                    itemController = itemController.GetComponent<ItemController>(),
                };
                break;
            case "HeroGun":
                player = new HeroGun(playerObject)
                {
                    camera = camera,
                    mapController = mapController.GetComponent<MapController>(),
                    itemController = itemController.GetComponent<ItemController>(),
                };
                break;
        }
    }

    void Update()
    {
        GameObject selectedCharater = CharacterSelect.selectedCharater;
        StartTimer();
        if (selectedCharater.name == "HeroGun" || selectedCharater.name == "HeroSword")
        {
            if (timerStarted)
            {
                timer += Time.deltaTime;
                if (timer >= 60f)
                {
                    // Increase HP, attack, and speed by 10%
                    player.health += 3;
                    player.damage += 1;
                    player.speed += 1;
                    player.speedAttack -= 0.05f;

                    // Reset timer
                    timer = 0f;
                    StopTimer();
                }
                //Debug.Log("H: " + player.health + " D: "+ player.damage + " S: "+ player.speed + " SA: "+ player.speedAttack);
                //Debug.Log("timerStarted:" + timerStarted + " timer: " + timer);
            }
        }
    }
    public void StartTimer()
    {
        timerStarted = true;
    }

    public void StopTimer()
    {
        timerStarted = false;
    }


}
