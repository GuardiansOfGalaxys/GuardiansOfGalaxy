using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enermy : MonoBehaviour
{

    private float currentSpeed;
    private float currentHealth;
    private float currentAttackSpeed;
    private float currenAttack;
    // round playing
    public int round = 1;

    private Transform target;
    private float distance;
    private int currentAttack;

    Character character;

    public HUD hub;
    public int damageEnemy;


    // Start is called before the first frame update
    void Start()
    {
        //enemy follow player
        target = Camera.main.transform;
        // get the name of the enemy prefab
        switch (gameObject.name)
        {
            case "EnermyLv1(Clone)":
                currentSpeed = CurrentEnemy.Enemy.EnemyLv1.speed;
                currentHealth = CurrentEnemy.Enemy.EnemyLv1.health;
                currenAttack = CurrentEnemy.Enemy.EnemyLv1.attack;
                currentAttackSpeed = CurrentEnemy.Enemy.EnemyLv1.attackSpeed;
                break;
            case "EnermyLv2(Clone)":
                currentSpeed = CurrentEnemy.Enemy.EnemyLv2.speed;
                currentHealth = CurrentEnemy.Enemy.EnemyLv2.health;
                currenAttack = CurrentEnemy.Enemy.EnemyLv2.attack;
                currentAttackSpeed = CurrentEnemy.Enemy.EnemyLv2.attackSpeed;
                break;
            case "EnermyLv3(Clone)":
                currentSpeed = CurrentEnemy.Enemy.EnemyLv3.speed;
                currentHealth = CurrentEnemy.Enemy.EnemyLv3.health;
                currenAttack = CurrentEnemy.Enemy.EnemyLv2.attack;
                currentAttackSpeed = CurrentEnemy.Enemy.EnemyLv2.attackSpeed;
                break;
            
        }

        hub = FindObjectOfType<HUD>();
        //Debug.Log(gameObject.name + "health: " + currentHealth);
    }

    // Update is called once per frame
    void Update()
    {

        //Follow player
        distance = Vector2.Distance(transform.position, target.position);
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, target.position, currentSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        
        // check round
        //UpdateEnemy();
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    //public void UpdateEnemy()
    //{
    //    // Check if the round has changed
    //    if (GameManager.instance.currentRound != round)
    //    {
    //        // Update the round number
    //        round = GameManager.instance.currentRound;

    //        // Increase the enemy's health and attack speed for the new round
    //        currentHealth += 2 * (round - 1);
    //        currenAttack += (round - 1);
    //        currentSpeed += 0.2f * (round - 1);
    //        currentAttackSpeed = currentAttackSpeed;
    //    } 
    //}

    public void TakeDamageInPlayer(int damage)
    {
        hub.HandleHealthChangedEvent(damage);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
                Debug.Log(gameObject.name);
                if (gameObject.name == "EnermyLv1(Clone)")
                {
                    currentAttack = CurrentEnemy.Enemy.EnemyLv1.attack;
                    TakeDamageInPlayer(currentAttack);
                    Destroy(gameObject);
                }
                else if (gameObject.name == "EnermyLv2(Clone)")
                {
                    currentAttack = CurrentEnemy.Enemy.EnemyLv2.attack;
                    TakeDamageInPlayer(currentAttack);
                    Destroy(gameObject);
                }
                else if (gameObject.name == "EnermyLv3(Clone)")
                {
                    currentAttack = CurrentEnemy.Enemy.EnemyLv3.attack;
                    TakeDamageInPlayer(currentAttack);
                    Destroy(gameObject);
                }    

        }

    }


}
