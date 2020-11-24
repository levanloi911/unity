using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doormap2 : MonoBehaviour
{
    private Animator anim;
    public bool outdoor;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        outdoor = false;

    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        outdoor = true;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("outdoor", outdoor);
    }
}
