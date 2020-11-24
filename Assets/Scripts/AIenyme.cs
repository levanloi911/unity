using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIenyme : MonoBehaviour
{
    public float distance;
    public float wakerange;
    public float shootinterval;
    public float bulletspeed = 5;
    public float bullettimer;

    public bool awake = false;
    public bool lookingRight = true;

    public GameObject bullet;
    public Transform target;
    public Animator anim;
    public Transform shootpointL, shootpointR;
    public int health = 100;

    public GameObject deathEffect;


    private void Awake()
    {
        anim = GetComponent<Animator>();

    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Awakee", awake);
        anim.SetBool("LookRightt", lookingRight);

        RangeCheck();

        if (target.transform.position.x > transform.position.x)
        {
            lookingRight = true;
        }

        if (target.transform.position.x < transform.position.x)
        {
            lookingRight = false;
        }

    }


    void RangeCheck()
    {
        distance = Vector2.Distance(transform.position, target.transform.position);

        if (distance < wakerange)
            awake = true;

        if (distance > wakerange)
            awake = false;
    }

    public void Attack(bool attackright)
    {
        bullettimer += Time.deltaTime;

        if (bullettimer >= shootinterval)
        {
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

            if (attackright)
            {
                GameObject bulletclone;
                bulletclone = Instantiate(bullet, shootpointR.transform.position, shootpointR.transform.rotation) as GameObject;
                bulletclone.GetComponent<Rigidbody2D>().velocity = direction * bulletspeed;

                bullettimer = 0;
            }

            if (!attackright)
            {
                GameObject bulletclone;
                bulletclone = Instantiate(bullet, shootpointL.transform.position, shootpointL.transform.rotation) as GameObject;
                bulletclone.GetComponent<Rigidbody2D>().velocity = direction * bulletspeed;

                bullettimer = 0;
            }
        }
    }

    public void Damage(int dmg)
    {
        health -= dmg;
        gameObject.GetComponent<Animation>().Play("redflat");
    }


    public void TakeDamage2(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}