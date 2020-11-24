using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealmap3 : MonoBehaviour
{
	public int health = 100;

	public GameObject deathEffect, destroywall;

	public void TakeDamage(int damage)
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
		DestroyObject(destroywall);
		Destroy(gameObject);
	}
	public void Damage(int damage)
	{
		health -= damage;
		gameObject.GetComponent<Animation>().Play("redflat");
	}

}
