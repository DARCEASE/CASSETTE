using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//PURPOSE:to display the submitted newspaper article based on dropdown choices (detect selections in drop down menus)
// USAGE: Place this on an empty gameobject called DropdownController  (works almsot like button controller scripts youve done) - when you program stuff, make functions for specific actions
// usage cont: now when you have that working, head into the drop down youre refering to, go to where it says OnValuesChanged() - drag in the GO with this script onit and find the function you want it to refer to 
// cont cont: now, when you select a specific dropdown, it should do something. 
public class ChTwoNB : MonoBehaviour
{
#region INITIALIZATIONS

    Scene scene;
    public string PlayerNewspaper, PlayerHeadline;
    
    //Audience Feedback Script
    public AudienceFeedbackScript AFS;
    public CH2Controller CH2;
    [SerializeField] GameObject NewspaperPanel;
    //Side Article
    [SerializeField] SideArticleScript SAS;
    public Text finalNewspaper, finalHeadline;
    
    //2: Boris, Guy, Vito, BB Man, Franz
    public Dropdown[] Char1DPs; //Drop downs for all Char1s
    public Dropdown[] Char2DPs;
    public Dropdown[] Char3DPs;
    public Dropdown[] Char4DPs;
    public Dropdown[] Char5DPs;

    //CH2
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
        if (Char1DPs[0].value ==1) // if you choose the first option for Novak Is.. 
        {  
            #region Ch1_Code
            //Make booleans for each option and then calculate them once the person hits submit
                CH2.APaper+=1;
                CH2.BorisOutputInt = 3;
                Ch2_Char1SelectionDoneA = true;
        
        }
        else if (Char1DPs[0].value ==2)
        {
                CH2.BPaper+=1;
                CH2.BorisSQOutputInt = 3;
                Ch2_Char1SelectionDoneA = true;
        }
        else if (Char1DPs[0].value ==3)
        {
                CH2.CPaper+=1;
                CH2.BorisTabOutputInt = 3;
                Ch2_Char1SelectionDoneA = true;
        }
        #endregion 
    }

    public void Char1DropB() // WHO second dropdown for Novak
    {
        #region Ch1_Code
        if (Char1DPs[1].value ==1) // if you choose the first option for Novak Is.. 
        {
            CH2.APaper+=1;
            CH2.BorisOutputInt = 1;
            Ch2_Char1SelectionDoneB = true;
        }
        else if (Char1DPs[1].value ==2)
        {
            CH2.BPaper+=1;
            CH2.BorisSQOutputInt = 1;
            Ch2_Char1SelectionDoneB = true;
        }
        else if (Char1DPs[1].value ==3)
        {
            CH2.CPaper+=1;
            CH2.BorisTabOutputInt = 1;
            Ch2_Char1SelectionDoneB = true;
        } 
        #endregion
    }
    
    public void Char1DropC()
    {
        #region Ch1_Code
        if (Char1DPs[2].value ==1) // if you choose the first option for Novak Is.. 
        {
            CH2.APaper+=1;
            CH2.BorisOutputInt = 2;
            Ch2_Char1SelectionDoneC = true;

        }
        else if (Char1DPs[2].value ==2)
        {
            CH2.BPaper+=1;
            CH2.BorisSQOutputInt = 2;
            Ch2_Char1SelectionDoneC = true;
        }
        else if (Char1DPs[2].value ==3)
        {
            CH2.CPaper+=1;
            CH2.BorisTabOutputInt = 2;
            Ch2_Char1SelectionDoneC = true;
        }

        #endregion
    }

    //JIM AP: 3,4,5
    public void Char2DropA() // JIM SENTENCE 1, Selection A
    {
        #region Ch1_Code
        if (Char2DPs[0].value ==1) 
        {
            CH2.APaper+=1;
            CH2.GuyOutputInt = 1;
            Ch2_Char2SelectionDoneA = true;
            
        }
        else if (Char2DPs[0].value ==2)
        {
            CH2.BPaper+=1;
            CH2.GuySQOutputInt = 1;
            Ch2_Char2SelectionDoneA = true;
            
        }
        else if (Char2DPs[0].value ==3)
        {
            CH2.CPaper+=1;
            CH2.GuyTabOutputInt = 1;
            Ch2_Char2SelectionDoneA = true;
            
        }
        #endregion
    }
    
    public void Char2DropB() // JIM SENTENCE 2, Selection B
    {
        #region Ch1_Code
        if (Char2DPs[1].value ==1) 
        {
            CH2.APaper+=1;
            CH2.GuyOutputInt = 3;
            Ch2_Char2SelectionDoneB = true;
        }
        else if (Char2DPs[1].value ==2)
        {

            CH2.BPaper+=1;
            CH2.GuySQOutputInt = 3;
            Ch2_Char2SelectionDoneB = true;
        }
        else if (Char2DPs[1].value ==3)
        {
            CH2.CPaper+=1;
            CH2.GuyTabOutputInt = 3;
            Ch2_Char2SelectionDoneB = true;
        }
        #endregion
    }

    public void Char2DropC() // JIM SENTENCE 3 
    {
        #region Ch1_Code
        if (Char2DPs[2].value ==1) 
        {
            CH2.APaper+=1;
            CH2.GuyOutputInt = 2;
            Ch2_Char2SelectionDoneC = true;
        }
        else if (Char2DPs[2].value ==2)
        {
            CH2.BPaper+=1;
            CH2.GuySQOutputInt = 2;
            Ch2_Char2SelectionDoneC = true;
        }
        else if (Char2DPs[2].value ==3)
        {
            CH2.CPaper+=1;
            CH2.GuyTabOutputInt = 2;
            Ch2_Char2SelectionDoneC = true;
        }
        #endregion
    }

    //JULIA AP:6,7,8
    public void Char3DropA()
    {
        #region Ch1_Code
        if (Char3DPs[0].value ==1) 
        {
            CH2.APaper+=1;
            CH2.DaniOutputInt = 1;
            Ch2_Char3SelectionDoneA = true;
        }
        else if (Char3DPs[0].value ==2)
        {
            CH2.BPaper+=1;
            CH2.DaniSQOutputInt = 1;
            Ch2_Char3SelectionDoneA = true;
        }
        else if (Char3DPs[0].value ==3)
        {
            CH2.CPaper+=1;
            CH2.DaniTabOutputInt = 1;
            Ch2_Char3SelectionDoneA = true;
            CH2.APaper+=1;
        }
        #endregion
    }

    public void Char3DropB()
    {
        #region Ch1_Code
        if (Char3DPs[1].value ==1)
        {
            CH2.APaper+=1;
            CH2.DaniOutputInt = 3;
            Ch2_Char3SelectionDoneB = true;
        }
        else if (Char3DPs[1].value ==2)
        {
            CH2.BPaper+=1;
            CH2.DaniSQOutputInt = 3;
            Ch2_Char3SelectionDoneB = true;
        }
        else if (Char3DPs[1].value ==3)
        {
            CH2.CPaper+=1;
            CH2.DaniTabOutputInt = 3;
            Ch2_Char3SelectionDoneB = true;
        }
        #endregion
    }

    public void Char3DropC()
    {
        #region Ch1_Code
        if (Char3DPs[2].value ==1)
        {
            CH2.APaper+=1;
            CH2.DaniOutputInt = 2;
            Ch2_Char3SelectionDoneC = true;
        }
        else if (Char3DPs[2].value ==2)
        {
            CH2.BPaper+=1;
            CH2.DaniSQOutputInt = 2;
            Ch2_Char3SelectionDoneC = true;

        }
        else if (Char3DPs[2].value ==3)
        {
            CH2.CPaper+=1;
            CH2.DaniTabOutputInt = 2;
            Ch2_Char3SelectionDoneC = true;
            CH2.APaper+=1;
        }
        #endregion
    }

    //MICHAEL AP: 12-14
    public void Char4DropA()
    {
        #region Ch1_Code
        if (Char4DPs[0].value ==1)
        {
            CH2.APaper+=1;
            CH2.CarlaSQOutputInt = 1;
            Ch2_Char4SelectionDoneA = true;
        }
        else if (Char4DPs[0].value ==2)
        {
            CH2.BPaper+=1;
            CH2.CarlaSQOutputInt = 1;
            Ch2_Char4SelectionDoneA = true;
        }
        else if (Char4DPs[0].value ==3)
        {
            CH2.CPaper+=1;
            CH2.CarlaTabOutputInt = 1;
            Ch2_Char4SelectionDoneA = true;            
        }
        #endregion
    }

    public void Char4DropB()
    {
        #region Ch1_Code
        if (Char4DPs[1].value ==1)
        {
            CH2.APaper+=1;
            CH2.CarlaOutputInt = 2;
            Ch2_Char4SelectionDoneB = true;
        }
        else if (Char4DPs[1].value ==2)
        {
            CH2.BPaper+=1;
            CH2.CarlaSQOutputInt = 2;
            Ch2_Char4SelectionDoneB = true;            
        }
        else if (Char4DPs[1].value ==3)
        {
            CH2.CPaper+=1;
            CH2.CarlaTabOutputInt = 2;
            Ch2_Char4SelectionDoneB = true;
        }
        #endregion
    }

    public void Char4DropC()
    {
        #region Ch1_Code
        if (Char4DPs[2].value ==1)
        {
            CH2.APaper+=1;
            CH2.CarlaOutputInt = 3;
            Ch2_Char4SelectionDoneC = true;
        }
        else if (Char4DPs[2].value ==2)
        {
            CH2.BPaper+=1;
            CH2.CarlaSQOutputInt = 3;
            Ch2_Char4SelectionDoneC = true;
        }
        else if (Char4DPs[2].value ==3)
        {
            CH2.CPaper+=1;
            CH2.CarlaTabOutputInt = 3;
            Ch2_Char4SelectionDoneC = true;
        }
        #endregion
    }

    //MAX AP: 9-11
    public void Char5DropA()
    {
        #region Ch1_Code
        if (Char5DPs[0].value == 1)
        {
            CH2.APaper+=1;
            CH2.NovakOutputInt = 3;
            Ch2_Char5SelectionDoneA = true;
        }
        else if (Char5DPs[0].value == 2)
        {
            CH2.BPaper+=1;
            CH2.NovakSQOutputInt = 3;
            Ch2_Char5SelectionDoneA = true;
        }
        else if (Char5DPs[0].value == 3)
        {
            CH2.CPaper+=1;
            CH2.NovakTabOutputInt = 3;
            Ch2_Char5SelectionDoneA = true;
        }
        #endregion
    }

    public void Char5DropB()
    {
        #region Ch1_Code
        if (Char5DPs[1].value ==1)
        {
            CH2.APaper+=1;
            CH2.NovakOutputInt = 2;
            Ch2_Char5SelectionDoneB = true;
        }
        else if (Char5DPs[1].value ==2)
        {
            CH2.BPaper+=1;
            CH2.NovakSQOutputInt = 2;
            Ch2_Char5SelectionDoneB = true;
            CH2.APaper+=1;
        }
        else if (Char5DPs[1].value ==3)
        {
            CH2.CPaper+=1;
            CH2.NovakTabOutputInt = 2;
            Ch2_Char5SelectionDoneB = true;            
        }
        #endregion
    }

    public void Char5DropC()
    {
        #region Ch1_Code
        if (Char5DPs[2].value ==1)
        {
            CH2.APaper+=1;
            CH2.NovakOutputInt = 1;
            Ch2_Char5SelectionDoneC = true;
        }
        else if (Char5DPs[2].value ==2)
        {
            CH2.BPaper+=1;
            CH2.NovakSQOutputInt = 1;
            Ch2_Char5SelectionDoneC = true;
        }
        else if (Char5DPs[2].value ==3)
        {
            CH2.CPaper+=1;
            CH2.NovakTabOutputInt = 1;
            Ch2_Char5SelectionDoneC = true;
            CH2.APaper+=1;
        }
        #endregion
    }

    public void NewspaperPrint() // using this to test things 
    {
        ///*
            finalNewspaper.text = PlayerNewspaper;
            finalHeadline.text = PlayerHeadline;

        //*/
    }
}