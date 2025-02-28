﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool pause = false;
    public GameObject pauseUI;

    // Use this for initialization
    void Start()
    {
        pauseUI.SetActive(false);
    }

    // Update is called once per frame
   public void Update()
    {
       
        if (pause)
        {
            pauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (pause == false)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1;
        }


    }
    public void Clickpause()
    {
        
        pause = !pause;
    }
    public void resume()
    {
        pause = false;
    }

    public void restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quit()
    {
        SceneManager.LoadScene(0);
    }
   
}