using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{
    public bool pause = false;
    public GameObject pauseUI;
   

    // Use this for initialization
    void Start()
    {
        pauseUI.SetActive(false);
    }
   
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;

            pauseUI.SetActive(true);
        }
    }


    public void playagain()
    {
        SceneManager.LoadScene(1);
    }

    public void Backmenu()
    {
        
      SceneManager.LoadScene(0);
        

    }
}