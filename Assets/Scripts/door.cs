using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public int Levelload;
    public gamemaster gm;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (Levelload == 2)
        {
            if (col.CompareTag("Player"))
            {
                savescore();
                gm.Inputtext.text = ("Vào Căn cứ(E)");
            }
        }
        else if (Levelload == 3)
        {
            if (col.CompareTag("Player"))
            {
                savescore();
                gm.Inputtext.text = ("Hãy trở về nhà(E)");
            }
        }

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                savescore();
                SceneManager.LoadScene(Levelload);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.Inputtext.text = ("");
        }
    }

    void savescore()
    {
        PlayerPrefs.SetInt("points", gm.points);
    }
}