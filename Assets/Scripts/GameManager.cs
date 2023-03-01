using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudienceFeedbackScript AFS;
    [SerializeField] TransitionScript TS;

    void Start()
    {
        AFS = GetComponent<AudienceFeedbackScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //restart game
        {
            SceneManager.LoadScene("StoryOneScene");
        }
    }

    public void NextStory()
    {
        TS.TransitionIn(); //Fades to Black
        SceneManager.LoadScene("StoryTwoScene");
        Debug.Log("StoryTwoScene");
        //AFS.FormulaCalculation();
    }

    public void StartGame()
    {
        /*
        TS.TransitionIn(); //Fades to Black
        SceneManager.LoadScene("StoryOneScene");
        SceneManager.LoadScene("HybridStoryOne");
        Debug.Log("BOOTING UP!");*/
        
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
