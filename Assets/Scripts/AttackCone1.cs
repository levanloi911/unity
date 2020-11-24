using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCone1 : MonoBehaviour
{
    public AIenyme aIenyme;
    public bool isLeft = false;


    private void Awake()
    {
        aIenyme = gameObject.GetComponentInParent<AIenyme>();

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (isLeft)
                aIenyme.Attack(false);

            else
                aIenyme.Attack(true);


        }
    }
}