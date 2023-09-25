using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Attack2 : MonoBehaviour
{
    private float cooldown;
    public float timeBtwAttack2 = 0.5f;

    public Transform attackPos2;
    public LayerMask whatIsEnemies2;
    public float attackRange2 = 1;
    public int health2 = 95;
    public int damage2 = 5;



    public UnityEvent<GameObject> OnHit, OnDeath;

    void Update()
    {

        if (cooldown <= 0)
        {

            if (Input.GetKey(KeyCode.E))

            {

                Collider2D[] enemiesTodamage2 = Physics2D.OverlapCircleAll(attackPos2.position, attackRange2, whatIsEnemies2);
                enemiesTodamage2[0].GetComponent<Attack1>().Takedamage1(damage2, transform.gameObject);

                cooldown = timeBtwAttack2;
            }


        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
    public void Takedamage2(int damage1, GameObject sender)
    {
        health2 -= damage1;

        if (health2 > 0)
        {
            OnHit?.Invoke(sender);
        }
        else
        {
            OnDeath?.Invoke(sender);
        }
        Debug.Log("damage2 Taken");
    }
}
