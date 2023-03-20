using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
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
    private bool timerUpdateCharacter = true;

    [SerializeField]
    GameObject propertyCharacterScene;
    [SerializeField]
    TextMeshProUGUI h1; //health start
    [SerializeField]
    TextMeshProUGUI h2; // health update
    [SerializeField]
    TextMeshProUGUI a1; //attack start
    [SerializeField]
    TextMeshProUGUI a2; //attack update
    [SerializeField]
    TextMeshProUGUI s1; //speed start
    [SerializeField]
    TextMeshProUGUI s2; //speed update
    [SerializeField]
    TextMeshProUGUI as1; //attack speed start
    [SerializeField]
    TextMeshProUGUI as2; //attack speed update


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

        if(selectedCharater.name == "HeroGun")
        {
            int healthGun = player.health;
            
            float dameGun = player.damage;
            float speedGun = player.speed;
            float attackSpeedGun = player.speedAttack;
        }

        if (selectedCharater.name == "HeroSword")
        {
            int healthSword = player.health;
            float dameSword = player.damage;
            float speedSword = player.speed;
            float attackSpeedSword = player.speedAttack;
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
                
                //Debug.Log("2. timerStarted:" + timerStarted + " timer: " + timer);
                timer += Time.deltaTime;
                if (timer >= 60f)
                {
                    // Increase HP, attack, and speed by 10%
                    h1.text = "" + player.health;
                    player.health += 3;
                    h2.text = "" + player.health;

                    a1.text = "" + player.damage;
                    player.damage += 1;
                    a2.text = "" + player.damage;

                    s1.text = "" + player.speed;
                    player.speed += 1;
                    s2.text = "" + player.speed;

                    as1.text = "" + player.speedAttack;
                    player.speedAttack -= 0.05f;
                    as2.text = "" + player.speedAttack;
                    // Reset timer
                    //StopTimer();
                    timerUpdateCharacter = true;
                    if(timerUpdateCharacter == true)
                    {
                        //Debug.Log( " timer: " + timer);
                        // Show properties update scene
                        propertyCharacterScene.SetActive(true);
                        Time.timeScale = 0f;
                        timer = 0f;
                        timerUpdateCharacter = false;
                    }

                }
                //Debug.Log("H: " + player.health + " D: "+ player.damage + " S: "+ player.speed + " SA: "+ player.speedAttack);
                //Debug.Log("2. timerStarted:" + timerStarted + " timer: " + timer);
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
