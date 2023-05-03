using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//PURPOSE:to display the submitted newspaper article based on dropdown choices (detect selections in drop down menus)
// USAGE: Place this on an empty gameobject called DropdownController  (works almsot like button controller scripts youve done) - when you program stuff, make functions for specific actions
// usage cont: now when you have that working, head into the drop down youre refering to, go to where it says OnValuesChanged() - drag in the GO with this script onit and find the function you want it to refer to 
// cont cont: now, when you select a specific dropdown, it should do something. 
public class NewspaperBehaviorCopy : MonoBehaviour
{
#region INITIALIZATIONS

    Scene scene;
    public string PlayerNewspaper, PlayerHeadline;
    
    //Audience Feedback Script
    public AudienceFeedbackScript AFS;
    public ROTDOREController ROTDORE;
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
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        NewspaperPrint();
    }

    //NOVAK AP: 0,1,2
    public void Char1DropA()
    {
        if (Char1DPOne.value == 1) // if you choose the first option for Novak Is.. 
        {  
            //Make booleans for each option and then calculate them once the person hits submit
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char1A1 = true;
                Char1B1 = false;
                Char1C1 = false;
                Char1SelectionDoneA = true;
                Debug.Log(Char1SelectionDoneA);
                ROTDORE.NovakSQOutputInt = 1;
                ROTDORE.muckrakerPaper += 1;
                //Feedback Vals
                AFS.unbiasedVal += 2;
            }

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1A1 = true;
                Char1B1 = false;
                Char1C1 = false;
                Char1SelectionDoneA = true;
                RUSSIA.FearfulPaper += 1;
            }
        }
        else if (Char1DPOne.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char1A1 = false;
                Char1B1 = true;
                Char1C1 = false;
                Char1SelectionDoneA = true;
                ROTDORE.NovakSQOutputInt = 2;
                ROTDORE.statusQuoPaper += 1;
                //Feedback Vals
                AFS.entertainingVal -= 1;    
            }

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1A1 = false;
                Char1B1 = true;
                Char1C1 = false;
                Char1SelectionDoneA = true;
                RUSSIA.AngryPaper += 1;
            }

        }
        else if (Char1DPOne.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){

                Char1A1 = false;
                Char1B1 = true;
                Char1C1 = false;
                ROTDORE.NovakSQOutputInt = 3;
                Char1SelectionDoneA = true;
                ROTDORE.NovakSQOutputInt = 3;
                ROTDORE.tabloidPaper += 1;
                //Feedback Vals
                AFS.credibleVal -= 3;
                AFS.unbiasedVal -= 2;
            }

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1A1 = false;
                Char1B1 = false;
                Char1C1 = true;
                Char1SelectionDoneA = true;
                RUSSIA.CompassionatePaper += 1;
            }
        }
    }

    public void Char1DropB() // WHO second dropdown for Novak
    {
        if (Char1DPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char1A2 = true;
                Char1B2 = false;
                Char1C2 = false;
                ROTDORE.muckrakerPaper+=1;
                Char1SelectionDoneB = true;
            }

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1A2 = true;
                Char1B2 = false;
                Char1C2 = false;
                Char1SelectionDoneA = true;
                RUSSIA.FearfulPaper += 1;
            }
        }
        else if (Char1DPTwo.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char1A2 = false;
                Char1B2 = true;
                Char1C2 = false;
                ROTDORE.statusQuoPaper+=1;
                Char1SelectionDoneB = true;
                //Feedback Vals
                AFS.entertainingVal -= 1;
            }

            if (scene.name == "StoryTwoScene" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Char1A2 = false;
                Char1B2 = true;
                Char1C2 = false;
                Char1SelectionDoneA = true;
                RUSSIA.AngryPaper += 1;
                RUSSIA.BorisBOutputInt = 2;
                RUSSIA.BorisCOutputInt = 3;
            }
        }
        else if (Char1DPTwo.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char1A2 = false;
                Char1B2 = false;
                Char1C2 = true;
                ROTDORE.tabloidPaper+=1;
                Char1SelectionDoneB = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal += 1;
            }
        } 
    }
    
    public void Char1DropC()
    {
        if (Char1DPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char1A3 = true;
                Char1B3 = false;
                Char1C3 = false;
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.NovakOutputInt = 1;
                ROTDORE.NovakTabOutputInt = 1;
                Char1SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal -= 3;
            }
        }
        else if (Char1DPThree.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char1A3 = false;
                Char1B3 = true;
                Char1C3 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.NovakOutputInt = 2;
                ROTDORE.NovakTabOutputInt = 2;
                Char1SelectionDoneC = true;
                //Feedback Vals
                AFS.credibleVal += 3;
                AFS.unbiasedVal += 2;
            }
        }
        else if (Char1DPThree.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char1A3 = false;
                Char1B3 = false;
                Char1C3 = true;
                ROTDORE.tabloidPaper+=1;
                ROTDORE.NovakOutputInt = 3;
                ROTDORE.NovakTabOutputInt = 3;
                Char1SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal -= 3;
                SAS.sideArt1 += 25;
            }
        }
    }

    //JIM AP: 3,4,5
    public void Char2DropA() // JIM SENTENCE 1, Selection A
    {
        if (Char2DPOne.value == 1) 
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A1 = true;
                Char2B1 = false;
                Char2C1 = false;
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JimTabOutputInt = 1;
                Char2SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
                SAS.sideArt1 += 25;
            }
        }
        else if (Char2DPOne.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A1 = false;
                Char2B1 = true;
                Char2C1 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JimTabOutputInt = 2;
                Char2SelectionDoneA = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
            }
        }
        else if (Char2DPOne.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A1 = false;
                Char2B1 = false;
                Char2C1 = true;
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JimTabOutputInt = 3;
                Char2SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
            }
        }

    }
    
    public void Char2DropB() // JIM SENTENCE 2, Selection B
    {
        if (Char2DPTwo.value == 1) 
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A2 = true;
                Char2B2 = false;
                Char2C2 = false;
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JimSQOutputInt = 1;
                Char2SelectionDoneB = true;
            }
        }
        else if (Char2DPOne.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A2 = false;
                Char2B2 = true;
                Char2C2 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JimSQOutputInt = 2;
                Char2SelectionDoneB = true;
                //Feedback Vals
                AFS.credibleVal += 3;
            }
        }
        else if (Char2DPOne.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A2 = false;
                Char2B2 = false;
                Char2C2 = true;
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JimSQOutputInt = 3;
                Char2SelectionDoneB = true;
            }
        }
    }

    public void Char2DropC() // JIM SENTENCE 3 
    {
        if (Char2DPThree.value == 1) 
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A3 = true;
                Char2B3 = false;
                Char2C3 = false;
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JimOutputInt = 1;
                Char2SelectionDoneC = true;
            }
        }
        else if (Char2DPThree.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A3 = false;
                Char2B3 = false;
                Char2C3 = true;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JimOutputInt = 2;
                Char2SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal -= 1;
                SAS.sideArt4 += 20;
            }
        }
        else if (Char2DPThree.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char2A3 = false;
                Char2B3 = false;
                Char2C3 = true;
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JimOutputInt = 3;
                Char2SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
                SAS.sideArt1 += 25;
            }
        }
    }

    //JULIA AP:6,7,8
    public void Char3DropA()
    {
        if (Char3DPOne.value == 1) 
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A1 = true;
                Char3B1 = false;
                Char3C1 = false;
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JuliaSQOutputInt = 1;
                Char3SelectionDoneA = true;
            }
        }
        else if (Char3DPOne.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A1 = false;
                Char3B1 = true;
                Char3C1 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JuliaSQOutputInt = 2;
                Char3SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal -= 2;
                AFS.unbiasedVal += 2;
            }
        }
        else if (Char3DPOne.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A1 = false;
                Char3B1 = false;
                Char3C1 = true;
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JuliaSQOutputInt = 3;
                Char3SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
            }
        }
    }

    public void Char3DropB()
    {
        if (Char3DPTwo.value == 1)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A2 = true;
                Char3B2 = false;
                Char3C2 = false;
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JuliaOutputInt = 1;
                Char3SelectionDoneB = true;
                //Feedback Vals
                AFS.entertainingVal -= 2;
            }
        }
        else if (Char3DPTwo.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A2 = false;
                Char3B2 = true;
                Char3C2 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JuliaOutputInt = 2;
                Char3SelectionDoneB = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
                SAS.sideArt4 += 20;
            }
        }
        else if (Char3DPTwo.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A2 = false;
                Char3B2 = false;
                Char3C2 = true;
                ROTDORE.tabloidPaper +=1;
                ROTDORE.JuliaOutputInt = 3;
                Char3SelectionDoneB = true;
                //Feedback Vals
                AFS.credibleVal -= 3;
                AFS.unbiasedVal -= 2;
            }
        }
    }

    public void Char3DropC()
    {
        if (Char3DPThree.value == 1)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A3 = true;
                Char3B3 = false;
                Char3C3 = false;
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JuliaTabOutputInt = 1;
                Char3SelectionDoneC = true;
                AFS.unbiasedVal -= 2;
            }
        }
        else if (Char3DPThree.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A3 = false;
                Char3B3 = true;
                Char3C3 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JuliaTabOutputInt = 2;
                Char3SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal -= 1;
                AFS.unbiasedVal += 2;
            }
        }
        else if (Char3DPThree.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char3A3 = false;
                Char3B3 = false;
                Char3C3 = true;
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JuliaTabOutputInt = 3;
                Char3SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
            }
        }
    }

    //MICHAEL AP: 12-14
    public void Char4DropA()
    {
        if (Char4DPOne.value == 1)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A1 = true;
                Char4B1 = false;
                Char4C1 = false;
                Char4SelectionDoneA = true;
                ROTDORE.muckrakerPaper += 1;
                ROTDORE.MikeTabOutputInt = 1;
                ROTDORE.MikeSQOutputInt = 1;
                ROTDORE.MikeOutputInt = 1;
                //Feedback Vals
                AFS.credibleVal += 3;
            }
        }
        else if (Char4DPOne.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A1 = false;
                Char4B1 = true;
                Char4C1 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MikeTabOutputInt = 2;
                ROTDORE.MikeSQOutputInt = 2;
                ROTDORE.MikeOutputInt = 2;
                Char4SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal -= 2;
                SAS.sideArt3 += 21;
            }
        }
        else if (Char4DPOne.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A1 = false;
                Char4B1 = false;
                Char4C1 = true;
                ROTDORE.tabloidPaper+=1;
                Char4SelectionDoneA = true;
                ROTDORE.MikeTabOutputInt = 3;
                ROTDORE.MikeSQOutputInt = 3;
                ROTDORE.MikeOutputInt = 3;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal += 3;
                SAS.sideArt2 += 65;
            }
        }
    }

    public void Char4DropB()
    {
        if (Char4DPTwo.value == 1)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A2 = true;
                Char4B2 = false;
                Char4C2 = false;
                ROTDORE.muckrakerPaper+=1;
                Char4SelectionDoneB = true;
                //Feedback Vals
                AFS.credibleVal += 2;
                AFS.unbiasedVal -= 2;
            }
        }
        else if (Char4DPTwo.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A2 = false;
                Char4B2 = true;
                Char4C2 = false;
                ROTDORE.statusQuoPaper+=1;
                Char4SelectionDoneB = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
            }
        }
        else if (Char4DPTwo.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A3 = false;
                Char4B3 = false;
                Char4C3 = true;
                ROTDORE.tabloidPaper+=1;
                Char4SelectionDoneB = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
                AFS.unbiasedVal -= 1;
                SAS.sideArt2 += 35;
            }
        }
    }

    public void Char4DropC()
    {
        if (Char4DPThree.value == 1)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A3 = true;
                Char4B3 = false;
                Char4C3 = false;
                ROTDORE.muckrakerPaper+=1;
                Char4SelectionDoneC = true;
                SAS.sideArt4 += 20;
            }
        }
        else if (Char4DPThree.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A3 = false;
                Char4B3 = true;
                Char4C3 = false;
                ROTDORE.statusQuoPaper+=1;
                Char4SelectionDoneC = true;
            }
        }
        else if (Char4DPThree.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4A3 = false;
                Char4B3 = false;
                Char4C3 = true;
                ROTDORE.tabloidPaper+=1;
                Char4SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal += 3;
            }
        }
    }

    //MAX AP: 9-11
    public void Char5DropA()
    {
        if (Char5DPOne.value == 1)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A1 = true;
                Char5B1 = false;
                Char5C1 = false;
                ROTDORE.muckrakerPaper+=1;
                Char5SelectionDoneA = true;
                ROTDORE.MaxSQOutputInt = 1;
                ROTDORE.MaxOutputInt = 1;
                //Feedback Vals
                AFS.unbiasedVal += 1;
                SAS.sideArt4 += 20;
            }

        }
        else if (Char5DPOne.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A1 = false;
                Char5B1 = true;
                Char5C1 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MaxSQOutputInt = 2;
                ROTDORE.MaxOutputInt = 2;
                Char5SelectionDoneA = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
            }
        }
        else if (Char5DPOne.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A1 = false;
                Char5B1 = false;
                Char5C1 = true;
                ROTDORE.tabloidPaper+=1;
                ROTDORE.MaxSQOutputInt = 3;
                ROTDORE.MaxOutputInt = 3;
                Char5SelectionDoneA = true;
                //Feedback Vals
                AFS.unbiasedVal -= 2;
            }
        }
    }

    public void Char5DropB()
    {
        if (Char5DPTwo.value == 1)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A2 = true;
                Char5B2 = false;
                Char5C2 = false;
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.MaxTabOutputInt = 1;
                Char5SelectionDoneB = true;
                //Feedback Vals
                AFS.unbiasedVal -= 2;
            }
        }
        else if (Char5DPTwo.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A2 = false;
                Char5B2 = true;
                Char5C2 = false;
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MaxTabOutputInt = 2;
                Char5SelectionDoneB = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
                SAS.sideArt3 += 21;
            }
        }
        else if (Char5DPTwo.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A2 = false;
                Char5B2 = false;
                Char5C2 = true;
                ROTDORE.tabloidPaper+=1;
                ROTDORE.MaxTabOutputInt = 3;
                Char5SelectionDoneB = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
            }
        }
    }

    public void Char5DropC()
    {
        if (Char5DPThree.value == 1)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A3 = true;
                Char5B3 = false;
                Char5C3 = false;
                ROTDORE.muckrakerPaper+=1;
                Char5SelectionDoneC = true;
            }
        }
        else if (Char5DPThree.value == 2)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A3 = false;
                Char5B3 = true;
                Char5C3 = false;
                ROTDORE.statusQuoPaper+=1;
                Char5SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal -= 2;
                AFS.credibleVal += 3;
                SAS.sideArt3 += 21;
            }
        }
        else if (Char5DPThree.value == 3)
        {
            if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char5A3 = false;
                Char5B3 = false;
                Char5C3 = true;
                ROTDORE.tabloidPaper+=1;
                Char5SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
                AFS.credibleVal -= 3;
            }
        }
    }

    public void NewspaperPrint() // using this to test things 
    {
        ///*
        finalNewspaper.text = ROTDORE.PlayerNewspaper;
        finalHeadline.text = ROTDORE.PlayerHeadline;
        //*/
    }
}