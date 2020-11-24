using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enyme_move : MonoBehaviour
{
    public float speed;
    public bool moveright;

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
       
        if (moveright)
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
            
        }
        else
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("turn"))
        {
            if (moveright)
            {
                moveright = false;
            }
            else
            {
                moveright = true;
            }
        }
    }
}
