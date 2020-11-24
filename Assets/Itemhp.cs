using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemhp : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            player.Addheal(1);
            Destroy(gameObject);
        }
    }
    }
