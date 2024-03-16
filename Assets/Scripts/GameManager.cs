using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudienceFeedbackScript AFS;
    [SerializeField] TransitionScript TS;
    [SerializeField] CharChangerScript CCS;
    Scene currentScene;

    void Start()
    {
        AFS = GetComponent<AudienceFeedbackScript>();
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    public void Update()
    {
        //TS.FadeOutScene();
        if (Input.GetKeyDown(KeyCode.Space) && currentScene.name == "TitleScreen")
        {
            TS.ToNextScene();
            
        }

        if (Input.GetKeyDown(KeyCode.R) && currentScene.name == "DEMO" || currentScene.name == "OfficialStoryOne" || currentScene.name == "TESTStoryOneScene 1" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "TESTStoryTwoScene 1" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "HybridStoryOne" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "HybridStoryTwo") //restart game
        {
            SceneManager.LoadScene("TitleScreen");
        }

        //Keypad shortcuts for exhibitions
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("DEMO");
            Debug.Log("Pressed 1");
        }

        /*if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("TESTStoryTwoScene 1");
            Debug.Log("Pressed 2");

        }*/

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("HybridStoryOne");
            Debug.Log("Pressed 3");
        }

        /*if (Input.GetKeyDown(KeyCode.Alpha4)) 
        {
            SceneManager.LoadScene("HybridStoryTwo");
            Debug.Log("Pressed 4");
        }*/

    }

    public void NextStory()
    {
        TS.ToNextScene();
        CCS.NewspaperGO.SetActive(false);
        for (int i = 0; i < CCS.GamePanels.Length; i++){
                CCS.GamePanels[i].SetActive(false);
                //Debug.Log("Not active");
            }
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
        //TS.ToNextScene();
        SceneManager.LoadScene("TitleScreen");
        Debug.Log("Thank you for playing :3");

    }

    public void EndCredits()

    {
        //Sends player to credit screen
        SceneManager.LoadScene("EndScene");
    }

    public void RestartGame()
    {
        //For hybrid version, if the player hits replay, the comp should check to see if the scene is the hybrid scene, then restart the hybrid scene
        //Currently brings player from Hybrid to digital ver scene
        //used to restart but also load in game from start scrn
        Scene scene = SceneManager.GetActiveScene();

        Debug.Log("restarting game commencing...");
        if (scene.name == "DEMO")
        {
            SceneManager.LoadScene("OfficialStoryOne");
        }
        else{
            SceneManager.LoadScene("HybridStoryOne");
        }
        
    }
     public void SafetyBuildRestart()
    {
        //Game will go back to the original game scene. Used to create a safety build for the digital version of Unreleased GA 2024
        SceneManager.LoadScene("OfficialStoryOne");
        Debug.Log("Thank you for playing :3");

    }
   
}
