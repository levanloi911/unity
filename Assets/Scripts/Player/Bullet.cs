using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public float lifetime = 2;

	public GameObject impactEffect;
	// Use this for initialization
	void Start()
	{
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
	{
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        TurretAI turretAI = hitInfo.GetComponent<TurretAI>();
		if (turretAI != null)
		{
			turretAI.TakeDamage1(damage);
		}
		AIenyme aIenyme = hitInfo.GetComponent<AIenyme>();
		if (aIenyme != null)
		{
			aIenyme.TakeDamage2(damage);
		}
		BossHealth enemy1 = hitInfo.GetComponent<BossHealth>();
		if (enemy1 != null)
		{
			enemy1.TakeDamage3(damage);
		}
		Enemyhealmap3 enemybossmap3 = hitInfo.GetComponent<Enemyhealmap3>();
		if (enemybossmap3 != null)
		{
			enemybossmap3.TakeDamage(damage);
		}

		Instantiate(impactEffect, transform.position, transform.rotation);
		Destroy(gameObject);
	}
	void Update()
	{
		lifetime -= Time.deltaTime;
		if (lifetime <= 0)
			Destroy(gameObject);
	}
}