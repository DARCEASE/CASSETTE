using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  


    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //restart game
        {
            SceneManager.LoadScene("DigitalVersion");
        }

    }

    
    

    public void RestartGame()

    {
        //used to restart but also load in game from start scrn
        Debug.Log("restarting game commencing...");
        SceneManager.LoadScene("DigitalVersion");
        
    }
   
}
