using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudienceFeedbackScript AFS;
    [SerializeField] TransitionScript TS;
    [SerializeField] CharChangerScript CCS;
    [SerializeField] NewspaperBehaviorCopy NBC;
    [SerializeField] FullDigitalUIBehavior UIB;
    Scene currentScene;

    void Start()
    {
        AFS = GetComponent<AudienceFeedbackScript>();
        currentScene = SceneManager.GetActiveScene();
    }

    public void Update()
    {
        //TS.FadeOutScene(); This is for transition screen to Ch 1
        if (Input.GetKeyDown(KeyCode.Space) && currentScene.name == "TitleScreen")
        {
            //TS.ToNextScene();
            StartCoroutine(LoadGameAsync());
        }

        if (Input.GetKeyDown(KeyCode.R) && currentScene.name == "DEMO" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "OfficialStoryOne" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "EndScene" )
        {
            SceneManager.LoadScene("TitleScreen");
        }

        //Keypad shortcuts for exhibitions
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("DEMO");
            Debug.Log("Pressed 1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("HybridStoryOne");
            Debug.Log("Pressed 3");
        }
    }

    //ENUM HERE, LOOK HERE
    IEnumerator LoadGameAsync(){
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("DEMO");

        while (!asyncLoad.isDone)
            yield return null;
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

    //temp function for the sake of time 
    public void FinishDemo()
    {   
        SceneManager.LoadScene("TitleScreen");
        Debug.Log("Thank you for playing :3");
    }

    public void EndCredits()
    {
        //Sends player to credit screen
        SceneManager.LoadScene("EndScene");
        
        /*for (int i = 0; i < UIB.FilePanels.Length; i++){
            UIB.FilePanels[i].gameObject.SetActive(false);
            Debug.Log(UIB.FilePanels[i]);
        }
        NBC.resetAll = true;*/
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
