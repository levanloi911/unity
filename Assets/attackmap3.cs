using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackmap3 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger == false)
        {
            if (col.CompareTag("Player"))
            {
                col.SendMessageUpwards("Damage", 1);
            }
        }
    }
}