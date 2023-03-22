using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using static Const.Item;

public class PlayerAttack : MonoBehaviour
{

    public GameObject attackArea = default;

    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
        button = GameObject.Find("BtnFire").GetComponent<Button>();
        button.onClick.AddListener(Attack);
    }

    // Update is called once per frame
    void Update()
    {

        if(attacking)
        {
            timer += Time.deltaTime;

            if (timer >= timeToAttack ) 
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }
    }

    private void Attack()
    {
        AudioManager.Play(AudioClipName.SwordFighting);
        attacking = true;
        attackArea.SetActive(attacking);
    }
}
