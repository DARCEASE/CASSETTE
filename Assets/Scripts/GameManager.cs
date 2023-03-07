using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudienceFeedbackScript AFS;
    [SerializeField] TransitionScript TS;
    Scene currentScene;

    void Start()
    {
        AFS = GetComponent<AudienceFeedbackScript>();
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentScene.name == "TitleScene") //restart game
        {
            TS.ToNextScene();
        }
    }

    public void NextStory()
    {
        SceneManager.LoadScene("StoryTwoScene");
        Debug.Log("StoryTwoScene");
        //AFS.FormulaCalculation();
    }

    public void StartGame()
    {
        ///*       
        SceneManager.LoadScene("HybridStoryOne");
        Debug.Log("BOOTING UP!");
        //*/
        
    }

    //temp function for the sake of time 
    public void FinishDemo()
    {
        //Game will go back to title screen 
        SceneManager.LoadScene("StoryOneScene");
        Debug.Log("Thank you for playing :3");

    }

    public void RestartGame()
    {
        //For hybrid version, if the player hits replay, the comp should check to see if the scene is the hybrid scene, then restart the hybrid scene
        //Currently brings player from Hybrid to digital ver scene
        //used to restart but also load in game from start scrn
        Scene scene = SceneManager.GetActiveScene();

        Debug.Log("restarting game commencing...");
        if (scene.name == "StoryOneScene")
        {
            SceneManager.LoadScene("StoryOneScene");
        }
        else{
            SceneManager.LoadScene("HybridStoryOne");
        }
        
    }
   
}
