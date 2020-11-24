using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAreaCheck : MonoBehaviour
{
    private enemymap_3 enemyParent;
    private void Awake()
    {
        enemyParent = GetComponentInParent<enemymap_3>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            enemyParent.target = collision.transform;
            enemyParent.inRange = true;
            enemyParent.hotZone.SetActive(true);

        }
    }
}
