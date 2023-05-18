using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//PURPOSE:to display the submitted newspaper article based on dropdown choices (detect selections in drop down menus)
// USAGE: Place this on an empty gameobject called DropdownController  (works almsot like button controller scripts youve done) - when you program stuff, make functions for specific actions
// usage cont: now when you have that working, head into the drop down youre refering to, go to where it says OnValuesChanged() - drag in the GO with this script onit and find the function you want it to refer to 
// cont cont: now, when you select a specific dropdown, it should do something. 
public class NPBehavior : MonoBehaviour
{
#region INITIALIZATIONS

    Scene scene;
    public string PlayerNewspaper, PlayerHeadline;
    
    //Audience Feedback Script
    public AudienceFeedbackScript AFS;
    public RussiaController RUSSIA;
    //Side Article
    [SerializeField] SideArticleScript SAS;
    public Text finalNewspaper, finalHeadline;
    
    //1: Novak, Jim, Julia, Max, Michael
    //2: Boris, Guy, Vito, BB Man, Franz
    public Dropdown Char1DPOne, Char1DPTwo, Char1DPThree;
    public Dropdown Char2DPOne, Char2DPTwo, Char2DPThree;
    public Dropdown Char3DPOne, Char3DPTwo, Char3DPThree;
    public Dropdown Char4DPOne, Char4DPTwo, Char4DPThree;
    public Dropdown Char5DPOne, Char5DPTwo, Char5DPThree;
    
    //Keeps track of which dropsdowns are complete. Broad so it can be used in future NPB scripts.
    //These will be accessed by CharacterCompleteCheck so it MUST BE PUBLIC!
    public bool Char1SelectionDoneA, Char1SelectionDoneB, Char1SelectionDoneC; 
    public bool Char2SelectionDoneA, Char2SelectionDoneB, Char2SelectionDoneC;
    public bool Char3SelectionDoneA, Char3SelectionDoneB, Char3SelectionDoneC;
    public bool Char4SelectionDoneA, Char4SelectionDoneB, Char4SelectionDoneC;
    public bool Char5SelectionDoneA, Char5SelectionDoneB, Char5SelectionDoneC;

    bool Char1A1, Char1B1, Char1C1, Char1A2, Char1B2, Char1C2, Char1A3, Char1B3, Char1C3; 
    bool Char2A1, Char2B1, Char2C1, Char2A2, Char2B2, Char2C2, Char2A3, Char2B3, Char2C3;
    bool Char3A1, Char3B1, Char3C1, Char3A2, Char3B2, Char3C2, Char3A3, Char3B3, Char3C3;
    bool Char4A1, Char4B1, Char4C1, Char4A2, Char4B2, Char4C2, Char4A3, Char4B3, Char4C3;
    bool Char5A1, Char5B1, Char5C1, Char5A2, Char5B2, Char5C2, Char5A3, Char5B3, Char5C3;
    
#endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        NewspaperPrint();
    }

    //NOVAK AP: 0,1,2
    public void Char1DropA()
    {
        if (Char1DPOne.value == 1) // if you choose the first option for Novak Is.. 
        {  
            //Make booleans for each option and then calculate them once the person hits submit
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){

                Char1SelectionDoneA = true;
                Debug.Log("DP 1 Work");
                RUSSIA.FearfulPaper += 1;
            }

        }
        else if (Char1DPOne.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1SelectionDoneA = true;
                Debug.Log("DP 2 Work");
                RUSSIA.AngryPaper += 1;
            }


        }
        else if (Char1DPOne.value == 3)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1SelectionDoneA = true;
                Debug.Log("DP 3 Work");
                RUSSIA.CompassionatePaper += 1;
            }

        }
    }

    public void Char1DropB() // WHO second dropdown for Novak
    {
        if (Char1DPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1SelectionDoneB = true;
                RUSSIA.FearfulPaper += 1;
                RUSSIA.BorisBOutputInt = 1;
                RUSSIA.BorisCOutputInt = 1;
            }

        }
        else if (Char1DPTwo.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1SelectionDoneB = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.BorisBOutputInt = 2;
                RUSSIA.BorisCOutputInt = 2;
            }

        }
        else if (Char1DPTwo.value == 3)
        {
    
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1SelectionDoneB = true;
                RUSSIA.CompassionatePaper += 1;
                RUSSIA.BorisBOutputInt = 3;
                RUSSIA.BorisCOutputInt = 3;
            }

        } 
    }
    
    public void Char1DropC()
    {
        if (Char1DPThree.value == 1) // if you choose the first option for Novak Is.. 
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1SelectionDoneC = true;
                RUSSIA.FearfulPaper += 1;
                RUSSIA.BorisAOutputInt = 1;
            }

        }
        else if (Char1DPThree.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1SelectionDoneC = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.BorisAOutputInt = 2;
            }

        }
        else if (Char1DPThree.value == 3)
        {
        
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1SelectionDoneC = true;
                RUSSIA.CompassionatePaper += 1;
                RUSSIA.BorisAOutputInt = 3;
            }

        }
    }

    //JIM AP: 3,4,5
    public void Char2DropA() // JIM SENTENCE 1, Selection A
    {
        if (Char2DPOne.value == 1) 
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneA = true;
                RUSSIA.FearfulPaper += 1;
                RUSSIA.VitoCOutputInt = 1;
            }

        }
        else if (Char2DPOne.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneA = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.VitoCOutputInt = 2;
            }

        }
        else if (Char2DPOne.value == 3)
        {
            
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneA = true;
                RUSSIA.VitoCOutputInt = 3;
                RUSSIA.CompassionatePaper += 1;
            }

        }

    }
    
    public void Char2DropB() // JIM SENTENCE 2, Selection B
    {
        if (Char2DPTwo.value == 1) 
        {
    
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneB = true;
                RUSSIA.FearfulPaper += 1;
            }

        }
        else if (Char2DPTwo.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneB = true;
                RUSSIA.AngryPaper += 1;
            }

        }
        else if (Char2DPTwo.value == 3)
        {
            
             if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneB = true;
                RUSSIA.CompassionatePaper += 1;
            }

        }
    }

    public void Char2DropC() // JIM SENTENCE 3 
    {
        if (Char2DPThree.value == 1) 
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneC = true;
                RUSSIA.FearfulPaper += 1;
                RUSSIA.VitoAOutputInt = 1;
                RUSSIA.VitoBOutputInt = 1;
            }

        }
        else if (Char2DPThree.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneC = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.VitoAOutputInt = 2;
                RUSSIA.VitoBOutputInt = 2;
            }

        }
        else if (Char2DPThree.value == 3)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char2SelectionDoneC = true;
                RUSSIA.CompassionatePaper += 1;
                RUSSIA.VitoAOutputInt = 3;
                RUSSIA.VitoBOutputInt = 3;
            }

        }
    }

    //JULIA AP:6,7,8
    public void Char3DropA()
    {
        if (Char3DPOne.value == 1) 
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneA = true;
                RUSSIA.FearfulPaper += 1;
                RUSSIA.GuyCOutputInt = 1;
            }

        }
        else if (Char3DPOne.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneA = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.GuyCOutputInt = 2;
            }

        }
        else if (Char3DPOne.value == 3)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneA = true;
                RUSSIA.CompassionatePaper += 1;
                RUSSIA.GuyCOutputInt = 3;
            }

        }
    }

    public void Char3DropB()
    {
        if (Char3DPTwo.value == 1)
        {

             if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneB = true;
                RUSSIA.FearfulPaper += 1;
                RUSSIA.GuyAOutputInt = 1;
                RUSSIA.GuyBOutputInt = 1;  
            }

        }
        else if (Char3DPTwo.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneB = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.GuyAOutputInt = 2;
                RUSSIA.GuyBOutputInt = 2;
            }

        }
        else if (Char3DPTwo.value == 3)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneB = true;
                RUSSIA.CompassionatePaper += 1;
                RUSSIA.GuyAOutputInt = 3;
                RUSSIA.GuyBOutputInt = 3;
            }
            
        }
    }

    public void Char3DropC()
    {
        if (Char3DPThree.value == 1)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneC = true;
                RUSSIA.FearfulPaper += 1;

            }

        }
        else if (Char3DPThree.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneC = true;
                RUSSIA.AngryPaper += 1;

            }

        }
        else if (Char3DPThree.value == 3)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char3SelectionDoneC = true;
                RUSSIA.CompassionatePaper += 1;

            }

        }
    }

    //MICHAEL AP: 12-14
    public void Char4DropA()
    {
        if (Char4DPOne.value == 1)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneA = true;
                RUSSIA.FearfulPaper += 1;
            }

        }
        else if (Char4DPOne.value == 2)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneA = true;
                RUSSIA.AngryPaper += 1;
            }

        }
        else if (Char4DPOne.value == 3)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneA = true;
                RUSSIA.CompassionatePaper += 1;
            }

        }
    }

    public void Char4DropB()
    {
        if (Char4DPTwo.value == 1)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneB = true;
                RUSSIA.FearfulPaper += 1;
            }

        }
        else if (Char4DPTwo.value == 2)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneB = true;
                RUSSIA.AngryPaper += 1;
            }

        }
        else if (Char4DPTwo.value == 3)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneB = true;
                RUSSIA.CompassionatePaper += 1;
            }

        }
    }

    public void Char4DropC()
    {
        if (Char4DPThree.value == 1)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneC = true;
                RUSSIA.FearfulPaper += 1;
                RUSSIA.BrightonAOutputInt = 1;
                RUSSIA.BrightonBOutputInt = 1;
                RUSSIA.BrightonCOutputInt = 1;
            }

        }
        else if (Char4DPThree.value == 2)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneC = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.BrightonAOutputInt = 2;
                RUSSIA.BrightonBOutputInt = 2;
                RUSSIA.BrightonCOutputInt = 2;

            }
        }
        else if (Char4DPThree.value == 3)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char4SelectionDoneC = true;
                RUSSIA.CompassionatePaper += 1;
                RUSSIA.BrightonAOutputInt = 3;
                RUSSIA.BrightonBOutputInt = 3;
                RUSSIA.BrightonCOutputInt = 3;

            }

        }
    }

    //MAX AP: 9-11
    public void Char5DropA()
    {
        if (Char5DPOne.value == 1)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneA = true;
                RUSSIA.FearfulPaper += 1;
            }

        }
        else if (Char5DPOne.value == 2)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneA = true;
                RUSSIA.AngryPaper += 1;
            }

        }
        else if (Char5DPOne.value == 3)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneA = true;
                RUSSIA.CompassionatePaper += 1;
            }

        }
    }

    public void Char5DropB()
    {
        if (Char5DPTwo.value == 1)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneB = true;
                RUSSIA.FearfulPaper += 1;
            }

        }
        else if (Char5DPTwo.value == 2)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneB = true;
                RUSSIA.AngryPaper += 1;
            }

        }
        else if (Char5DPTwo.value == 3)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneB = true;
                RUSSIA.CompassionatePaper += 1;

            }

        }
    }

    public void Char5DropC()
    {
        if (Char5DPThree.value == 1)
        {

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneC = true;
                RUSSIA.FearfulPaper += 1;
                RUSSIA.FranzAOutputInt = 1;
                RUSSIA.FranzBOutputInt = 1;
                RUSSIA.FranzCOutputInt = 1;
            }

        }
        else if (Char5DPThree.value == 2)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneC = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.FranzAOutputInt = 2;
                RUSSIA.FranzBOutputInt = 2;
                RUSSIA.FranzCOutputInt = 2;
            }

        }
        else if (Char5DPThree.value == 3)
        {
            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char5SelectionDoneC = true;
                RUSSIA.CompassionatePaper += 1;
                RUSSIA.FranzAOutputInt = 3;
                RUSSIA.FranzBOutputInt = 3;
                RUSSIA.FranzCOutputInt = 3;
            }  
        }
    }

    void NewspaperPrint() // using this to test things 
    {
        ///*
        if (scene.name == "TESTStoryTwoScene 1" || scene.name == "HybridStoryTwo" ){
            finalNewspaper.text = RUSSIA.PlayerNewspaper;
            finalHeadline.text = RUSSIA.PlayerHeadline;
            SAS.ROTDORESAS();
        }
        
        //*/
    }
}