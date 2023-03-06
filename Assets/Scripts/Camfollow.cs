using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camfollow : MonoBehaviour
{
    //public GameObject player;
    public static Character player;
    // Start is called before the first frame update
    void Start()
    {
        GameObject selectedCharater = CharacterSelect.selectedCharater;
        GameObject playerObject = Instantiate(selectedCharater, new Vector3(0, 0, 0), Quaternion.identity);
        playerObject.name = "Player";
        switch (selectedCharater.name)
        {
            case "HeroSword":
                player = new HeroSword(playerObject);
                break;
            case "HeroGun":
                player = new HeroGun(playerObject);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

    }
}
