using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject attackArea = default;

    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Attack();
        }

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
        attacking = true;
        attackArea.SetActive(attacking);
    }
}
