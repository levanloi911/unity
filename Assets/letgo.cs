using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class letgo : MonoBehaviour
{
    public bool pause = false;
    public GameObject pauseUI;

    

    // Use this for initialization
    void Start()
    {
        pauseUI.SetActive(false);
      
      
    }

    // Update is called once per frame
    void Update()
    {

     
            pauseUI.SetActive(true);
       

    }
    

    public void play()
    {

        SceneManager.LoadScene(1);
    }
    public void quit()
    {
          
        Application.Quit();
    }

}
