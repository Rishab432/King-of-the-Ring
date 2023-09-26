using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Attack1 : MonoBehaviour
{
    private float cooldown;
    public float timeBtwAttack1 = 0.5f;

    public Transform attackPos1;
    public LayerMask whatIsEnemies1;
    public float attackRange1 = 1;
    public static int health1 = 1;
    public int damage1 = 1;




    public UnityEvent<GameObject> OnHit, OnDeath;

    // Update is called once per frame


    void Update()
    {

        if (cooldown <= 0)
        {

            if (Input.GetKey(KeyCode.E))

            {
                Collider2D[] enemiesTodamage1 = Physics2D.OverlapCircleAll(attackPos1.position, attackRange1, whatIsEnemies1);
                enemiesTodamage1[0].GetComponent<Attack2>().Takedamage2(damage1, transform.gameObject);


                cooldown = timeBtwAttack1;


            }

        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
    public void Takedamage1(int damage2, GameObject sender)
    {
        health1 += damage2;
        KnockbackFeedback.strength = health1;
        if (health1 > 0)
        {
            OnHit?.Invoke(sender);
        }
        else
        {
            OnDeath?.Invoke(sender);
        }
    }
}