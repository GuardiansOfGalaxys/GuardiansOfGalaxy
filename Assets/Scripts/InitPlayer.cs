using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPlayer : MonoBehaviour
{
    public static Character player;
    [SerializeField]
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        GameObject selectedCharater = CharacterSelect.selectedCharater;
        GameObject playerObject = Instantiate(selectedCharater, new Vector3(0,0,0), Quaternion.identity);
        playerObject.name = "Player";

        switch (selectedCharater.name)
        {
            case "HeroSword":
                player = new HeroSword(playerObject);
                player.camera = cam;
                break;
            case "HeroGun":
                player = new HeroGun(playerObject);
                player.camera = cam;
                break;
        }
    }
        
}
