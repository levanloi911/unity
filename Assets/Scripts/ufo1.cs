using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo1 : MonoBehaviour
{
 
        public int health = 100;
        public float timer = 1;
        public Vector3 direction;
        

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;

            if (health <= 0)
                Destroy(this.gameObject);

            transform.Translate(direction * Time.deltaTime / 0.8f);

            if (timer > 1)
            {
                timer = 0;
                newposition();
            }

        }

    
        void newposition()
        {
            direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);

        }


    }
