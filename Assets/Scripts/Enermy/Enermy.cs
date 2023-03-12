using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enermy : MonoBehaviour
{

    private float currentSpeed;
    private float currentHealth;



    private Transform target;
    private float distance;


    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.transform;
        switch (gameObject.name) // get the name of the enemy prefab
        {
            case "EnermyLv1(Clone)":
                currentSpeed = CurrentEnemy.Enemy.EnemyLv1.speed;
                currentHealth = CurrentEnemy.Enemy.EnemyLv1.health;
                break;
            case "EnermyLv2(Clone)":
                currentSpeed = CurrentEnemy.Enemy.EnemyLv2.speed;
                currentHealth = CurrentEnemy.Enemy.EnemyLv2.health;
                break;
            case "EnermyLv3(Clone)":
                currentSpeed = CurrentEnemy.Enemy.EnemyLv3.speed;
                currentHealth = CurrentEnemy.Enemy.EnemyLv3.health;
                break;
            //default:
            //    currentSpeed = speedLv1;
            //    currentHealth = maxHealthLv1;
            //    break;
        }
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
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
