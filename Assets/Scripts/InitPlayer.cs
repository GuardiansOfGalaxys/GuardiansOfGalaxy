using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject selectedCharater = CharacterSelect.selectedCharater;
        Instantiate(selectedCharater, new Vector3(0,0,0), Quaternion.identity);
    }


        
}
