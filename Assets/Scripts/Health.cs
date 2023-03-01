using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    public int health = 100;

    private int MAX_HEALTH = 100;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            //Damage(10);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(20);
        }
    }

    private IEnumerator VisualIndicator(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Can't hava negative Damage");
        }
        this.health -= amount;
        StartCoroutine(VisualIndicator(Color.red));
        if (health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Can't hava negative Healing");

        }
        bool wouldBeOverMaxHeal = health + amount > MAX_HEALTH;
        StartCoroutine(VisualIndicator(Color.green));

        if (wouldBeOverMaxHeal)
        {
            this.health = MAX_HEALTH;
        } else
        {
            this.health += amount;
        }
        
    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }
    private void Die()
    {
        Debug.Log("I'm die");
        Destroy(gameObject);
    }
}
