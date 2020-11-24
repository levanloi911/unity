using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public Player player;


    

   //void Start()
   // {

   //    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
   // }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger == false)
        {
            if (col.CompareTag("Player"))
            {
                col.SendMessageUpwards("Damage", 1);
                //player.Knockback(100f, player.transform.position);
            }
            //Destroy(gameObject);
        }

    }
    //private void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.CompareTag("Player"))
    //    {
    //        player.Damage(1);
    //        player.Knockback(350f, player.transform.position);
    //    }
    //}
}
