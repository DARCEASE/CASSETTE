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
    public CH2Controller CH2;
    [SerializeField] GameObject NewspaperPanel;
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

    //Test
    //0-2: Ch1, 3-5, Ch2
    [SerializeField] Dropdown[] Char1, Char2, Char3, Char4, Char5;

    
    //Keeps track of which dropsdowns are complete. Broad so it can be used in future NPB scripts.
    //These will be accessed by CharacterCompleteCheck so it MUST BE PUBLIC!
    public bool Char1SelectionDoneA, Char1SelectionDoneB, Char1SelectionDoneC; 
    public bool Char2SelectionDoneA, Char2SelectionDoneB, Char2SelectionDoneC;
    public bool Char3SelectionDoneA, Char3SelectionDoneB, Char3SelectionDoneC;
    public bool Char4SelectionDoneA, Char4SelectionDoneB, Char4SelectionDoneC;
    public bool Char5SelectionDoneA, Char5SelectionDoneB, Char5SelectionDoneC;

    //Ch2
    public bool Ch2_Char1SelectionDoneA, Ch2_Char1SelectionDoneB, Ch2_Char1SelectionDoneC; 
    public bool Ch2_Char2SelectionDoneA, Ch2_Char2SelectionDoneB, Ch2_Char2SelectionDoneC;
    public bool Ch2_Char3SelectionDoneA, Ch2_Char3SelectionDoneB, Ch2_Char3SelectionDoneC;
    public bool Ch2_Char4SelectionDoneA, Ch2_Char4SelectionDoneB, Ch2_Char4SelectionDoneC;
    public bool Ch2_Char5SelectionDoneA, Ch2_Char5SelectionDoneB, Ch2_Char5SelectionDoneC;
    public bool resetAll;
    
#endregion

    // Start is called before the first frame update
    void Start()
    {
        NewspaperPanel.SetActive(false);
        scene = SceneManager.GetActiveScene();
        //if (resetAll == true)
        //    ResetAllVars();
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
            #region Ch1_Code
            //Make booleans for each option and then calculate them once the person hits submit
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"  || scene.name == "DEMO"){
                Char1SelectionDoneA = true;
                ROTDORE.NovakOutputInt = 3;
                ROTDORE.muckrakerPaper += 1;
                //Feedback Vals
                AFS.unbiasedVal += 2;
                Debug.Log("Testing for Novak 1");
            }
            
            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                Ch2_Char1SelectionDoneA = true;
                Debug.Log("Testing for Answer Boris 1");
            }
        }
        else if (Char1DPOne.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
                Char1SelectionDoneA = true;
                ROTDORE.NovakSQOutputInt = 3;
                ROTDORE.statusQuoPaper += 1;
                //Feedback Vals
                AFS.entertainingVal -= 1;    
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char1SelectionDoneA = true;
                Debug.Log("Testing for Boris Answer 2");
            }
        }
        else if (Char1DPOne.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
                ROTDORE.NovakTabOutputInt = 3;
                Char1SelectionDoneA = true;
                ROTDORE.tabloidPaper += 1;
                //Feedback Vals
                AFS.credibleVal -= 3;
                AFS.unbiasedVal -= 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){

                CH2.APaper+=1;
                Ch2_Char1SelectionDoneA = true;
                Debug.Log("Testing for Boris Answer 3");
            }
        }
        #endregion 
    }

    public void Char1DropB() // WHO second dropdown for Novak
    {
        #region Ch1_Code
        if (Char1DPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
                ROTDORE.muckrakerPaper+=1;
                Char1SelectionDoneB = true;
                ROTDORE.NovakOutputInt = 1;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                Ch2_Char1SelectionDoneB = true;
                Debug.Log("Testing for Answer 2");
            }
        }
        else if (Char1DPTwo.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){               
                ROTDORE.statusQuoPaper+=1;
                Char1SelectionDoneB = true;
                ROTDORE.NovakSQOutputInt = 1;
                //Feedback Vals
                AFS.entertainingVal -= 1;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                Ch2_Char1SelectionDoneB = true;
                Debug.Log("Testing for Answer 2");
            }
        }
        else if (Char1DPTwo.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
                ROTDORE.tabloidPaper+=1;
                Char1SelectionDoneB = true;
                ROTDORE.NovakTabOutputInt = 1;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal += 1;
            }
            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                Ch2_Char1SelectionDoneB = true;
                Debug.Log("Testing for Answer 2");
            }
        } 
        #endregion
    }
    
    public void Char1DropC()
    {
        #region Ch1_Code
        if (Char1DPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
               
                ROTDORE.muckrakerPaper+=1;
                Char1SelectionDoneC = true;
                ROTDORE.NovakOutputInt = 2;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal -= 3;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                Ch2_Char1SelectionDoneC = true;
                Debug.Log("Testing for Answer 3");
            }

        }
        else if (Char1DPThree.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
                                
                ROTDORE.statusQuoPaper+=1;
                Char1SelectionDoneC = true;
                ROTDORE.NovakSQOutputInt = 2;
                //Feedback Vals
                AFS.credibleVal += 3;
                AFS.unbiasedVal += 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                Ch2_Char1SelectionDoneC = true;
                Debug.Log("Testing for Answer 3");
            }
        }
        else if (Char1DPThree.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
                                              
                ROTDORE.tabloidPaper+=1;
                ROTDORE.NovakTabOutputInt = 3;
                Char1SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal -= 3;
                SAS.sideArt1 += 25;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                Ch2_Char1SelectionDoneC = true;
                Debug.Log("Testing for Answer 3");
            }

        }

        #endregion
    }

    //JIM AP: 3,4,5
    public void Char2DropA() // JIM SENTENCE 1, Selection A
    {
        #region Ch1_Code
        if (Char2DPOne.value == 1) 
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){

                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JimOutputInt = 1;
                Char2SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
                SAS.sideArt1 += 25;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneA = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        else if (Char2DPOne.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){

                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JimSQOutputInt = 1;
                Char2SelectionDoneA = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneA = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        else if (Char2DPOne.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){

                ROTDORE.tabloidPaper+=1;
                ROTDORE.JimTabOutputInt = 1;
                Char2SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneA = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        #endregion
    }
    
    public void Char2DropB() // JIM SENTENCE 2, Selection B
    {
        #region Ch1_Code
        if (Char2DPTwo.value == 1) 
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
               
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JimOutputInt = 2;
                Char2SelectionDoneB = true;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneB = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        else if (Char2DPTwo.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"|| scene.name == "DEMO"){

                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JimSQOutputInt = 2;
                Char2SelectionDoneB = true;
                //Feedback Vals
                AFS.credibleVal += 3;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneB = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        else if (Char2DPTwo.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){

                ROTDORE.tabloidPaper+=1;
                ROTDORE.JimTabOutputInt = 2;
                Char2SelectionDoneB = true;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneB = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        #endregion
    }

    public void Char2DropC() // JIM SENTENCE 3 
    {
        #region Ch1_Code
        if (Char2DPThree.value == 1) 
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){               
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JimOutputInt = 3;
                Char2SelectionDoneC = true;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneC = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        else if (Char2DPThree.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"|| scene.name == "DEMO"){                               
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JimSQOutputInt = 3;
                Char2SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal -= 1;
                SAS.sideArt4 += 20;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneC = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        else if (Char2DPThree.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
                                
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JimTabOutputInt = 3;
                Char2SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
                SAS.sideArt1 += 25;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneC = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        #endregion
        #region Ch2_Code
        if (Char2DPThree.value == 1) 
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){
               
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JimOutputInt = 3;
                Char2SelectionDoneC = true;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneC = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        else if (Char2DPThree.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){                               
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JimSQOutputInt = 3;
                Char2SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal -= 1;
                SAS.sideArt4 += 20;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneC = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        else if (Char2DPThree.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "DEMO"){                              
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JimTabOutputInt = 3;
                Char2SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
                SAS.sideArt1 += 25;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene"){
                CH2.APaper+=1;
                Ch2_Char2SelectionDoneC = true;
                ROTDORE.NovakOutputInt = 1;
            }
        }
        #endregion
    }

    //JULIA AP:6,7,8
    public void Char3DropA()
    {
        #region Ch1_Code
        if (Char3DPOne.value == 1) 
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JuliaOutputInt = 1;
                Char3SelectionDoneA = true;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char3SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        else if (Char3DPOne.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JuliaSQOutputInt = 1;
                Char3SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal -= 2;
                AFS.unbiasedVal += 2;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char3SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        else if (Char3DPOne.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JuliaTabOutputInt = 1;
                Char3SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){

                Ch2_Char3SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        #endregion
    }

    public void Char3DropB()
    {
        #region Ch1_Code
        if (Char3DPTwo.value == 1)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JuliaOutputInt = 2;
                Char3SelectionDoneB = true;
                //Feedback Vals
                AFS.entertainingVal -= 2;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char3SelectionDoneB = true;
                CH2.APaper+=1;  
            }

        }
        else if (Char3DPTwo.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JuliaSQOutputInt = 2;
                Char3SelectionDoneB = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
                SAS.sideArt4 += 20;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char3SelectionDoneB = true;
                CH2.APaper+=1;
            }

        }
        else if (Char3DPTwo.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper +=1;
                ROTDORE.JuliaTabOutputInt = 2;
                Char3SelectionDoneB = true;
                //Feedback Vals
                AFS.credibleVal -= 3;
                AFS.unbiasedVal -= 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char3SelectionDoneB = true;
                CH2.APaper+=1;
            }      
        }
        #endregion
    }

    public void Char3DropC()
    {
        #region Ch1_Code
        if (Char3DPThree.value == 1)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.JuliaOutputInt = 3;
                Char3SelectionDoneC = true;
                AFS.unbiasedVal -= 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char3SelectionDoneC = true;
                CH2.APaper+=1;
            }

        }
        else if (Char3DPThree.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.JuliaSQOutputInt = 3;
                Char3SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal -= 1;
                AFS.unbiasedVal += 2;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char3SelectionDoneC = true;
                CH2.APaper+=1;
            }

        }
        else if (Char3DPThree.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper+=1;
                ROTDORE.JuliaTabOutputInt = 3;
                Char3SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char3SelectionDoneC = true;
                CH2.APaper+=1;

            }
        }
        #endregion
    }

    //MICHAEL AP: 12-14
    public void Char4DropA()
    {
        #region Ch1_Code
        if (Char4DPOne.value == 1)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                Char4SelectionDoneA = true;
                ROTDORE.muckrakerPaper += 1;
                ROTDORE.MikeOutputInt = 1;
                //Feedback Vals
                AFS.credibleVal += 3;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        else if (Char4DPOne.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MikeSQOutputInt = 1;
                Char4SelectionDoneA = true;
                //Feedback Vals
                AFS.entertainingVal -= 2;
                SAS.sideArt3 += 21;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        else if (Char4DPOne.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper+=1;
                Char4SelectionDoneA = true;
                ROTDORE.MikeTabOutputInt = 1;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal += 3;
                SAS.sideArt2 += 65;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        #endregion
    }

    public void Char4DropB()
    {
        #region Ch1_Code
        if (Char4DPTwo.value == 1)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.MikeOutputInt = 2;
                Char4SelectionDoneB = true;
                //Feedback Vals
                AFS.credibleVal += 2;
                AFS.unbiasedVal -= 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneB = true;
                CH2.APaper+=1;
            }

        }
        else if (Char4DPTwo.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MikeSQOutputInt = 2;
                Char4SelectionDoneB = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneB = true;
                CH2.APaper+=1;
            }

        }
        else if (Char4DPTwo.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper+=1;
                ROTDORE.MikeTabOutputInt = 2;
                Char4SelectionDoneB = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
                AFS.unbiasedVal -= 1;
                SAS.sideArt2 += 35;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneB = true;
                CH2.APaper+=1;
            }

        }
        #endregion
    }

    public void Char4DropC()
    {
        #region Ch1_Code
        if (Char4DPThree.value == 1)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.MikeOutputInt = 3;
                Char4SelectionDoneC = true;
                SAS.sideArt4 += 20;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneC = true;
                CH2.APaper+=1;
            }
        }
        else if (Char4DPThree.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MikeSQOutputInt = 3;
                Char4SelectionDoneC = true;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneC = true;
                CH2.APaper+=1;

            }

        }
        else if (Char4DPThree.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper+=1;
                ROTDORE.MikeTabOutputInt = 3;
                Char4SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
                AFS.credibleVal += 3;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char4SelectionDoneC = true;
                CH2.APaper+=1;
            }

        }
        #endregion
    }

    //MAX AP: 9-11
    public void Char5DropA()
    {
        #region Ch1_Code
        if (Char5DPOne.value == 1)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.muckrakerPaper+=1;
                Char5SelectionDoneA = true;
                ROTDORE.MaxOutputInt = 1;
                //Feedback Vals
                AFS.unbiasedVal += 1;
                SAS.sideArt4 += 20;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        else if (Char5DPOne.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MaxSQOutputInt = 1;
                Char5SelectionDoneA = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        else if (Char5DPOne.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper+=1;
                ROTDORE.MaxTabOutputInt = 1;
                Char5SelectionDoneA = true;
                //Feedback Vals
                AFS.unbiasedVal -= 2;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneA = true;
                CH2.APaper+=1;
            }

        }
        #endregion
    }

    public void Char5DropB()
    {
        #region Ch1_Code
        if (Char5DPTwo.value == 1)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.MaxOutputInt = 2;
                Char5SelectionDoneB = true;
                //Feedback Vals
                AFS.unbiasedVal -= 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneB = true;
                CH2.APaper+=1;
            }

        }
        else if (Char5DPTwo.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MaxSQOutputInt = 2;
                Char5SelectionDoneB = true;
                //Feedback Vals
                AFS.unbiasedVal += 2;
                SAS.sideArt3 += 21;
            }

             if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneB = true;
                CH2.APaper+=1;
            }

        }
        else if (Char5DPTwo.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper+=1;
                ROTDORE.MaxTabOutputInt = 2;
                Char5SelectionDoneB = true;
                //Feedback Vals
                AFS.entertainingVal += 2;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneB = true;
                CH2.APaper+=1;
            }

        }
        #endregion
    }

    public void Char5DropC()
    {
        #region Ch1_Code
        if (Char5DPThree.value == 1)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.muckrakerPaper+=1;
                ROTDORE.MaxOutputInt = 3;
                Char5SelectionDoneC = true;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneC = true;
                CH2.APaper+=1;
            }

        }
        else if (Char5DPThree.value == 2)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.statusQuoPaper+=1;
                ROTDORE.MaxSQOutputInt = 3;
                Char5SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal -= 2;
                AFS.credibleVal += 3;
                SAS.sideArt3 += 21;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneC = true;
                CH2.APaper+=1;
            }

        }
        else if (Char5DPThree.value == 3)
        {
            if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
                ROTDORE.tabloidPaper+=1;
                ROTDORE.MaxTabOutputInt = 3;
                Char5SelectionDoneC = true;
                //Feedback Vals
                AFS.entertainingVal += 1;
                AFS.credibleVal -= 3;
            }

            if (scene.name == "OfficialStoryTwo" || scene.name == "HybridStoryTwo" || scene.name == "TESTStoryTwoScene 1"){
                Ch2_Char5SelectionDoneC = true;
                CH2.APaper+=1;
            }  
        }
        #endregion
    }

    public void NewspaperPrint() // using this to test things 
    {
        ///*
        if (scene.name == "OfficialStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "HybridStoryOne" || scene.name == "DEMO" ){
            finalNewspaper.text = ROTDORE.PlayerNewspaper;
            finalHeadline.text = ROTDORE.PlayerHeadline;
        }

        if (scene.name == "OfficialStoryTwo") {
            finalNewspaper.text = CH2.PlayerNewspaper;
            finalHeadline.text = ROTDORE.PlayerHeadline;
        }
        //*/
    }
}