using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class InitPlayer : MonoBehaviour
{
    public static Character player;
    [SerializeField]
    public Camera camera;
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
                player.camera = camera;
                break;
            case "HeroGun":
                player = new HeroGun(playerObject);
                player.camera = camera;
                break;
        }
    }

}
