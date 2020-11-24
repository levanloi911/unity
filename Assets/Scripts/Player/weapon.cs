using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
   public SoundManager sound;
    void Start()
    {
        sound = GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            sound.Playsound("phitieu");

            Shoot();
        }
        
    }
    void Shoot()
    {
        //shooting logic  
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       

    }
}
