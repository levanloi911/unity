using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nhatthuoc : MonoBehaviour
{
 
    public gamemaster gm;
  

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {  
            gm.Inputtext.text = ("Hãy Nhặt phương thuôc(N)");
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.N))
            {
                gm.Inputtext.text = ("Bạn đã Nhận được thuốc");
               
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.Inputtext.text = ("");
            Destroy(gameObject);
           
        }
        
    }

  
}