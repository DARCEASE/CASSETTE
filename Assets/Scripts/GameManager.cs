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
            ToNextScene();
        }

        if (Input.GetKeyDown(KeyCode.R) && currentScene.name == "DEMO" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "OfficialStoryOne" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "OfficialStoryTwo" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "OfficialStoryThree" || Input.GetKeyDown(KeyCode.R) && currentScene.name == "EndScene")
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
    /*IEnumerator LoadGameAsync(){
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("DEMO");

        while (!asyncLoad.isDone)
            yield return null;
    }*/

     public void ToNextScene(){
        StartCoroutine(LoadLevel());
    }
 
    IEnumerator LoadLevel(){ 
        TS.FadeIn();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
        if (currentScene.name != "TitleScreen" || currentScene.name != "EndScene"){
        //Closes all windows
            CCS.NewspaperGO.SetActive(false);
            for (int i = 0; i < CCS.GamePanels.Length; i++){
                CCS.GamePanels[i].SetActive(false);
            }
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
    }

    public void RestartGame()
    {
        //For hybrid version, if the player hits replay, the comp should check to see if the scene is the hybrid scene, then restart the hybrid scene
        //Currently brings player from Hybrid to digital ver scene
        //used to restart but also load in game from start scrn        
    }
     public void SafetyBuildRestart()
    {
        //Game will go back to the original game scene. Used to create a safety build for the digital version of Unreleased GA 2024
        SceneManager.LoadScene("OfficialStoryOne");
        Debug.Log("Thank you for playing :3");

    }
   
}
