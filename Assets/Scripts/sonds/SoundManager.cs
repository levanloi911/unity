using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip coins, destroy, phitieu;

    public AudioSource adisrc;
    // Use this for initialization
    void Start()
    {
        coins = Resources.Load<AudioClip>("G");
        destroy = Resources.Load<AudioClip>("R");
        phitieu = Resources.Load<AudioClip>("phitieu");
        adisrc = GetComponent<AudioSource>();

    }

    public void Playsound(string clip)
    {
        switch (clip)
        {
            case "coins":
                adisrc.clip = coins;
                adisrc.PlayOneShot(coins, 0.6f);
                break;

            case "destroy":
                adisrc.clip = destroy;
                adisrc.PlayOneShot(destroy, 1f);
                break;
            case "phitieu":
                adisrc.clip = destroy;
                adisrc.PlayOneShot(phitieu, 1f);
                break;


        }
    }
}
