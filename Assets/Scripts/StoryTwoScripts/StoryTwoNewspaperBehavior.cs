using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTwoNewspaperBehavior : MonoBehaviour
{

   #region INITIALIZATIONS
    public string PlayerNewspaper, PlayerHeadline, AngryNewspaper, CompassionateNewspaper, FearfulNewspaper;
   

    //Audience Feedback Script
    public AudienceFeedbackScript AFS;

    //All paper holding strings
    // APaper = Angry, BPaper = Fearful, CPaper = Compassionte
    string BorisAPaperString, BorisBPaperString, BorisCPaperString;
    string GuyAPaperString, GuyBPaperString, GuyCPaperString;
    string VitoAPaperString, VitoBPaperString, VitoCPaperString;
    string BrightonAPaperString, BrightonBPaperString, BrightonCPaperString;
    string FranzAPaperString, FranzBPaperString, FranzCPaperString;
    
    public Text finalNewspaper, finalHeadline;
    [SerializeField] int BorisAOutputInt, GuyAOutputInt, VitoAOutputInt, BrightonAOutputInt, FranzAOutputInt;//angry
    [SerializeField] int BorisBOutputInt, GuyBOutputInt, VitoBOutputInt, BrightonBOutputInt, FranzBOutputInt;//fearful
    [SerializeField] int BorisCOutputInt, GuyCOutputInt, VitoCOutputInt, BrightonCOutputInt, FranzCOutputInt;//compassionate

    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] newspaperPrints, ApaperArticlePieces, BPaperArticlePieces, CPaperArticlePieces;// angry, fearful, Compassionate article pieces 
    [SerializeField] string[] newspaperHeadlines;
   

    // MAKE A VARIABLE FOR THE DROPDOWN ITSELF 
    public Dropdown BorisDPOne, BorisDPTwo, BorisDPThree;
    public Dropdown VitoDPOne, VitoDPTwo, VitoDPThree;
    public Dropdown GuyDPOne, GuyDPTwo, GuyDPThree;
    public Dropdown FranziskaDPOne, FranziskaDPTwo, FranziskaDPThree;
    public Dropdown BrightonDPOne, BrightonDPTwo, BrightonDPThree;

    //Keeps track of which dropsdowns are complete. Broad so it can be used in future NPB scripts.
    //These will be accessed by CharacterCompleteCheck so it MUST BE PUBLIC!
    public bool Char1SelectionDoneA, Char1SelectionDoneB, Char1SelectionDoneC;
    public bool Char2SelectionDoneA, Char2SelectionDoneB, Char2SelectionDoneC;
    public bool Char3SelectionDoneA, Char3SelectionDoneB, Char3SelectionDoneC;
    public bool Char4SelectionDoneA, Char4SelectionDoneB, Char4SelectionDoneC;
    public bool Char5SelectionDoneA, Char5SelectionDoneB, Char5SelectionDoneC;

    //Values
    [SerializeField] int  AngryPaper,FearfulPaper, CompassionatePaper;
#endregion

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        NewspaperPrint();
    }
    /*
    WITH ARRAYS: Similar to what the old version of the code is doing, but sums everything up with one line of code. There will be 3 options for the player to choose from
    per dropdown menu. Whichever option in the menu the player chooses will be stored into the character's info array, which can be accessed by other classes.
    */

    //BORIS AP: 0,1,2
    public void BorisDropA()
    {
        if (BorisDPOne.value == 1) // if you choose the first option for Novak Is.. 
        {  
            FearfulPaper+=1; //TONE
            BorisBOutputInt = 1; //Paragraph Output 
            Char1SelectionDoneA = true; 
            
        }
        else if (BorisDPOne.value == 2)
        {
            AngryPaper+=1;
           Char1SelectionDoneA = true;
           
            
        }
        else if (BorisDPOne.value == 3)
        {
            CompassionatePaper+=1;
            Char1SelectionDoneA = true;
        }
    }
    public void BorisDropB() // WHO second dropdown for Novak
    {
        if (BorisDPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            FearfulPaper+=1;
            Char1SelectionDoneB = true;
            
            
        }
        else if (BorisDPTwo.value == 2)
        {
            AngryPaper+=1;
            Char1SelectionDoneB = true;
            
        }
        else if (BorisDPTwo.value == 3)
        {
            CompassionatePaper+=1;
            Char1SelectionDoneB = true;
        } 
    }
    public void BorisDropC()
    {
        if (BorisDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            FearfulPaper+=1;
            Char1SelectionDoneC = true;
            
        }
        else if (BorisDPThree.value == 2)
        {
            AngryPaper+=1;
            Char1SelectionDoneC = true;
            
        }
        else if (BorisDPThree.value == 3)
        {
            CompassionatePaper+=1;
            Char1SelectionDoneC = true;
        }
    }

    //VITO
    public void VitoDropA() // JIM SENTENCE 1
    {
        if (VitoDPOne.value == 1) 
        {
            FearfulPaper+=1;
            Char3SelectionDoneA = true;
        }
        else if (VitoDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 1 Opt 2");
            Char3SelectionDoneA = true;
            AngryPaper+=1;
        }
        else if (VitoDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 1 Opt 3");
            Char3SelectionDoneA = true;
            CompassionatePaper+=1;
        }
    }
    public void VitoDropB() // JIM SENTENCE 2
    {
        if (VitoDPTwo.value == 1) 
        {
            Debug.Log("JIM. Drop 2 Opt 1");
            Char3SelectionDoneB = true;
            FearfulPaper+=1;
        }
        else if (VitoDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 2 Opt 2");
            Char3SelectionDoneB = true;
            AngryPaper+=1;
        }
        else if (VitoDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 2 Opt 3");
            Char3SelectionDoneB = true;
            CompassionatePaper+=1;
        }
    }
    public void VitoDropC() // JIM SENTENCE 3 
    {
        if (VitoDPThree.value == 1) 
        {
            Debug.Log("JIM. Drop 3 Opt 1");
            Char3SelectionDoneC = true;
            FearfulPaper+=1;
        }
        else if (VitoDPThree.value == 2)
        {
            Debug.Log("JIM. Drop 3 Opt 2");
            Char3SelectionDoneC = true;
            AngryPaper+=1;
        }
        else if (VitoDPThree.value == 3)
        {
            Debug.Log("JIM. Drop 3 Opt 3");
            Char3SelectionDoneC = true;
            CompassionatePaper+=1;
        } 
    }

    //GUY 
    public void GuyDropA()
    {
        if (GuyDPOne.value == 1) 
        {
            Debug.Log("JULIA. Drop 1 Opt 1");
            Char2SelectionDoneA = true;
            FearfulPaper+=1;
        }
        else if (GuyDPOne.value == 2)
        {
            Debug.Log("JULIA. Drop 1 Opt 2");
            Char2SelectionDoneA = true;
            AngryPaper+=1;
            
        }
        else if (GuyDPOne.value == 3)
        {
            Debug.Log("JULIA. Drop 1 Opt 3");
            Char2SelectionDoneA = true;
            CompassionatePaper+=1;
        }
    }
    public void GuyDropB()
    {
        if (GuyDPTwo.value == 1)
        {
            Debug.Log("JULIA. Drop 2 Opt 1");
            Char2SelectionDoneB = true;
            FearfulPaper+=1;
        }
        else if (GuyDPTwo.value == 2)
        {
            Debug.Log("JULIA. Drop 2 Opt 2");
            Char2SelectionDoneB = true;
            AngryPaper+=1;
        }
        else if (GuyDPTwo.value == 3)
        {
            Debug.Log("JULIA. Drop 2 Opt 3");
            Char2SelectionDoneB = true;
            CompassionatePaper+=1;
        }
    }
    public void GuyDropC()
    {
        if (GuyDPThree.value == 1)
        {
            FearfulPaper+=1;
            Char2SelectionDoneC = true;
        }
        else if (GuyDPThree.value == 2)
        {
            
            AngryPaper+=1;
            Char2SelectionDoneC = true;
        }
        else if (GuyDPThree.value == 3)
        {            
            CompassionatePaper+=1;
            Char2SelectionDoneC = true;
        }
    }

    //FRANZ 
    public void FranziskaDropA()
    {
        if (FranziskaDPOne.value == 1)
        {
            FearfulPaper+=1;
            Char5SelectionDoneA = true;
        }
        else if (FranziskaDPOne.value == 2)
        {
            AngryPaper+=1;
            Char5SelectionDoneA = true;
        }
        else if (FranziskaDPOne.value == 3)
        {
            CompassionatePaper+=1;
            Char5SelectionDoneA = true;
        }
    }
    public void FranziskaDropB()
    {
        if (FranziskaDPTwo.value == 1)
        {
            FearfulPaper+=1;
            Char5SelectionDoneB = true;
        }
        else if (FranziskaDPTwo.value == 2)
        {
            AngryPaper+=1;
            Char5SelectionDoneB = true;
        }
        else if (FranziskaDPTwo.value == 3)
        {
            CompassionatePaper+=1;
            Char5SelectionDoneB = true;
        }
    }
    public void FranziskaDropC()
    {
        if (FranziskaDPThree.value == 1)
        {
            FearfulPaper+=1;
            Char5SelectionDoneC = true;
        }
        else if (FranziskaDPThree.value == 2)
        {
            AngryPaper+=1;
            Char5SelectionDoneC = true;
        }
        else if (FranziskaDPThree.value == 3)
        {
            CompassionatePaper+=1;
            Char5SelectionDoneC = true;
            }
        }

    //BRIGHTON BEACH MAN
    public void BrightonDropA()
    {
        if (BrightonDPOne.value == 1)
        {
            FearfulPaper+=1;
            Char4SelectionDoneA = true;
        }
        else if (BrightonDPOne.value == 2)
        {
            AngryPaper+=1;
            Char4SelectionDoneA = true;
        }
        else if (BrightonDPOne.value == 3)
        {
            CompassionatePaper+=1;
            Char4SelectionDoneA = true;
        }
    }
    public void BrightonDropB()
    {
        if (BrightonDPTwo.value == 1)
        {
            FearfulPaper+=1;
            Char4SelectionDoneB = true;
        }
        else if (BrightonDPTwo.value == 2)
        {
            AngryPaper+=1;
            Char4SelectionDoneB = true;
        }
        else if (BrightonDPTwo.value == 3)
        {
            CompassionatePaper+=1;
            Char4SelectionDoneB = true;
        }
    }
    public void BrightonDropC()
    {
        if (BrightonDPThree.value == 1)
        {
            FearfulPaper+=1;
            Char4SelectionDoneC = true;
        }
        else if (BrightonDPThree.value == 2)
        {
            AngryPaper+=1;
            Char4SelectionDoneC = true;
        }
        else if (BrightonDPThree.value == 3)
        {
            CompassionatePaper+=1;
            Char4SelectionDoneC = true;
        }
    }
    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt; 
        
        //For determining which paper to print when they're equal
        if (FearfulPaper == AngryPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = "This is a fearful paper."; //newspaperPrints[0]; //need to change this for the different outputs
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = "This is a angry paper."; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }   
        }

        if (FearfulPaper == CompassionatePaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = "This is a fearful paper."; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = "This is a compassionate paper."; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (CompassionatePaper == AngryPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = "This is a compassionate paper."; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = "This is an angry paper."; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }
        }

        if (CompassionatePaper == FearfulPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = "This is a compassionate paper."; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = "This is a fearful paper."; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
            }
        }

        if (AngryPaper == CompassionatePaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = "This is an angry paper."; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }
            else{
                PlayerNewspaper = "This is a compassionate paper."; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (AngryPaper == FearfulPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
            PlayerNewspaper = "This is an angry paper."; //newspaperPrints[1];
            PlayerHeadline = newspaperHeadlines[1];
           }   
            else{
                PlayerNewspaper = "This is a fearful paper."; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
            }    
        }

        //if they are not equal, it'll jump over here
        if (FearfulPaper > CompassionatePaper && FearfulPaper > AngryPaper){
           PlayerNewspaper = newspaperPrints[0];
           PlayerHeadline = newspaperHeadlines[0];
        }
        else if (AngryPaper > CompassionatePaper && AngryPaper > FearfulPaper){
            PlayerNewspaper = newspaperPrints[1];
            PlayerHeadline = newspaperHeadlines[1];
        }
        else if (CompassionatePaper > FearfulPaper && CompassionatePaper > AngryPaper){
            PlayerNewspaper = newspaperPrints[2];
            PlayerHeadline = newspaperHeadlines[2];
        }
        finalNewspaper.text = PlayerNewspaper;
        finalHeadline.text = PlayerHeadline;

    }
}
