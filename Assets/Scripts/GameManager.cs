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
        //For hybrid version, if the player hits replay, the comp should check to see if the scene is the hybrid scene, then restart the hybrid scene
        //Currently brings player from Hybrid to digital ver scene
        //used to restart but also load in game from start scrn
        Scene scene = SceneManager.GetActiveScene();

        Debug.Log("restarting game commencing...");
        if (scene.name == "DigitalVersion"){
            SceneManager.LoadScene("DigitalVersion");
        }
        else{
            SceneManager.LoadScene("HybridVersion");
        }
        
    }
   
}
