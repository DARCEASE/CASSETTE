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
    [SerializeField] string[] newspaperPrints, APaperArticlePieces, BPaperArticlePieces, CPaperArticlePieces;// angry, fearful, Compassionate article pieces 
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

    //BORIS (4-6)
    public void BorisDropA()
    {
        if (BorisDPOne.value == 1) // if you choose the first option for Novak Is.. 
        {  
            FearfulPaper+=1; //TONE
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
    public void BorisDropB()
    {
        if (BorisDPTwo.value == 1) //boris dropdown 2, choice 1 
        {
            FearfulPaper += 1;
            BorisBOutputInt = 1;
            BorisCOutputInt = 1;
            Char1SelectionDoneB = true;
            
            
        }
        else if (BorisDPTwo.value == 2)
        {
            AngryPaper+=1;
            BorisBOutputInt = 2; //Paragraph Output 
            BorisCOutputInt = 2;
            Char1SelectionDoneB = true;
            
        }
        else if (BorisDPTwo.value == 3)
        {
            CompassionatePaper+=1;
            BorisBOutputInt = 3; //Paragraph Output 
            BorisCOutputInt = 3;
            Char1SelectionDoneB = true;
        }

        //If B (FEarful)
        if (BorisBOutputInt == 1){
            BorisBPaperString = BPaperArticlePieces[4];

        } else if (BorisBOutputInt == 2){
            BorisBPaperString = BPaperArticlePieces[5];
        } else if (BorisBOutputInt == 3){
            BorisBPaperString = BPaperArticlePieces[6];
        }

        //If C (Comp)
        if (BorisCOutputInt == 1){
            BorisCPaperString = CPaperArticlePieces[4];

        } else if (BorisCOutputInt == 2){
            BorisCPaperString = CPaperArticlePieces[5];
        } else if (BorisCOutputInt == 3){
            BorisCPaperString = CPaperArticlePieces[6];
        }
    }
    public void BorisDropC()
    {
        if (BorisDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            FearfulPaper += 1;
            BorisAOutputInt = 1;
            Char1SelectionDoneC = true;
            
        }
        else if (BorisDPThree.value == 2)
        {
            AngryPaper+=1;
            BorisAOutputInt = 2;
            Char1SelectionDoneC = true;
            
        }
        else if (BorisDPThree.value == 3)
        {
            CompassionatePaper+=1;
            BorisAOutputInt = 3;
            Char1SelectionDoneC = true;
        }

        //If A (Angry)
        if (BorisAOutputInt == 1){
            BorisAPaperString = APaperArticlePieces[4];

        } else if (BorisAOutputInt == 2){
            BorisAPaperString = APaperArticlePieces[5];
        } else if (BorisAOutputInt == 3){
            BorisAPaperString = APaperArticlePieces[6];
        }
    }

    //VITO (9-11)
    public void VitoDropA() // JIM SENTENCE 1
    {
        if (VitoDPOne.value == 1) 
        {
            FearfulPaper+=1;
            VitoCOutputInt = 1;
            Char3SelectionDoneA = true;
        }
        else if (VitoDPOne.value == 2)
        {
            Char3SelectionDoneA = true;
            VitoCOutputInt = 2;
            AngryPaper+=1;
        }
        else if (VitoDPOne.value == 3)
        {
            Char3SelectionDoneA = true;
            VitoCOutputInt = 3;
            CompassionatePaper+=1;
        }

        
        if (VitoCOutputInt == 1){
            VitoCPaperString = CPaperArticlePieces[9];

        } else if (VitoCOutputInt == 2){
            VitoCPaperString = CPaperArticlePieces[10];
        } else if (VitoCOutputInt == 3){
            VitoCPaperString = CPaperArticlePieces[11];
        }
    }
    public void VitoDropB() // JIM SENTENCE 2
    {
        if (VitoDPTwo.value == 1) 
        {
            Char3SelectionDoneB = true;
            FearfulPaper+=1;
        }
        else if (VitoDPOne.value == 2)
        {
            Char3SelectionDoneB = true;
            AngryPaper+=1;
        }
        else if (VitoDPOne.value == 3)
        {
            Char3SelectionDoneB = true;
            CompassionatePaper+=1;
        }
    }
    public void VitoDropC() // JIM SENTENCE 3 
    {
        if (VitoDPThree.value == 1) 
        {
            Char3SelectionDoneC = true;
            VitoAOutputInt = 1;
            VitoBOutputInt = 1;
            FearfulPaper+=1;
        }
        else if (VitoDPThree.value == 2)
        {
            Char3SelectionDoneC = true;
            VitoAOutputInt = 2;
            VitoBOutputInt = 2;
            AngryPaper+=1;
        }
        else if (VitoDPThree.value == 3)
        {
            Char3SelectionDoneC = true;
            VitoAOutputInt = 3;
            VitoBOutputInt = 3;
            CompassionatePaper+=1;
        }

        if (VitoAOutputInt == 1){
            VitoAPaperString = APaperArticlePieces[9];

        } else if (VitoAOutputInt == 2){
            VitoAPaperString = APaperArticlePieces[10];
        } else if (VitoAOutputInt == 3){
            VitoAPaperString = APaperArticlePieces[11];
        }

        if (VitoBOutputInt == 1){
            VitoBPaperString = BPaperArticlePieces[9];
        } else if (VitoBOutputInt == 2){
            VitoBPaperString = BPaperArticlePieces[10];
        } else if (VitoBOutputInt == 3){
            VitoBPaperString = BPaperArticlePieces[11];
        }
    }

    //GUY (6-8)
    public void GuyDropA()
    {
        if (GuyDPOne.value == 1) 
        {
            Char2SelectionDoneA = true;
            GuyCOutputInt = 1;
            FearfulPaper+=1;
        }
        else if (GuyDPOne.value == 2)
        {
            Char2SelectionDoneA = true;
            GuyCOutputInt = 2;
            AngryPaper+=1;
            
        }
        else if (GuyDPOne.value == 3)
        {
            Char2SelectionDoneA = true;
            GuyCOutputInt = 3;
            CompassionatePaper+=1;
        }

        if (GuyCOutputInt == 1){
            GuyCPaperString = CPaperArticlePieces[6];
        } else if (VitoBOutputInt == 2){
             GuyCPaperString = CPaperArticlePieces[7];
        } else if (VitoBOutputInt == 3){
             GuyCPaperString = CPaperArticlePieces[8];
        }
    }
    public void GuyDropB()
    {
        if (GuyDPTwo.value == 1)
        {
            Char2SelectionDoneB = true;
            GuyBOutputInt = 1;
            GuyAOutputInt = 1;
            FearfulPaper+=1;
        }
        else if (GuyDPTwo.value == 2)
        {
            Char2SelectionDoneB = true;
            GuyBOutputInt = 2;
            GuyAOutputInt = 2;
            AngryPaper+=1;
        }
        else if (GuyDPTwo.value == 3)
        {
            Char2SelectionDoneB = true;
            GuyBOutputInt = 3;
            GuyAOutputInt = 3;
            CompassionatePaper+=1;
        }

        if (GuyAOutputInt == 1){
            GuyAPaperString = APaperArticlePieces[6];
        } else if (VitoBOutputInt == 2){
            GuyAPaperString = APaperArticlePieces[7];
        } else if (VitoBOutputInt == 3){
            GuyAPaperString = APaperArticlePieces[8];
        }

        if (GuyBOutputInt == 1){
            GuyBPaperString = BPaperArticlePieces[6];
        } else if (GuyBOutputInt == 2){
            GuyBPaperString = BPaperArticlePieces[7];
        } else if (GuyBOutputInt == 3){
            GuyBPaperString = BPaperArticlePieces[8];
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

    //FRANZ (12-14)
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
            FranzAOutputInt = 1;
            FranzBOutputInt = 1;
            FranzCOutputInt = 1;
            Char5SelectionDoneC = true;
        }
        else if (FranziskaDPThree.value == 2)
        {
            AngryPaper+=1;
            FranzAOutputInt = 2;
            FranzBOutputInt = 2;
            FranzCOutputInt = 2;
            Char5SelectionDoneC = true;
        }
        else if (FranziskaDPThree.value == 3)
        {
            CompassionatePaper+=1;
            FranzAOutputInt = 3;
            FranzBOutputInt = 3;
            FranzCOutputInt = 3;
            Char5SelectionDoneC = true;
        }

        if (FranzAOutputInt == 1){
            FranzAPaperString = APaperArticlePieces[12];
        } else if (FranzAOutputInt == 2){
            FranzAPaperString = APaperArticlePieces[13];
        } else if (FranzAOutputInt == 3){
            FranzAPaperString = APaperArticlePieces[14];
        }

        if (FranzBOutputInt == 1){
            FranzBPaperString = BPaperArticlePieces[12];
        } else if (FranzBOutputInt == 2){
            FranzBPaperString = BPaperArticlePieces[13];
        } else if (FranzBOutputInt == 3){
            FranzBPaperString = BPaperArticlePieces[14];
        }

        if (FranzCOutputInt == 1){
            FranzCPaperString = CPaperArticlePieces[12];
        } else if (FranzCOutputInt == 2){
            FranzCPaperString = CPaperArticlePieces[13];
        } else if (FranzCOutputInt == 3){
            FranzCPaperString = CPaperArticlePieces[14];
        }
    }

    //BRIGHTON BEACH MAN (0-2)
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
            BrightonAOutputInt = 1;
            BrightonBOutputInt = 1;
            BrightonCOutputInt = 1;
            Char4SelectionDoneC = true;
        }
        else if (BrightonDPThree.value == 2)
        {
            AngryPaper+=1;
            BrightonAOutputInt = 2;
            BrightonBOutputInt = 2;
            BrightonCOutputInt = 2;
            Char4SelectionDoneC = true;
        }
        else if (BrightonDPThree.value == 3)
        {
            CompassionatePaper+=1;
            BrightonAOutputInt = 3;
            BrightonBOutputInt = 3;
            BrightonCOutputInt = 3;
            Char4SelectionDoneC = true;
        }

        
        if (BrightonAOutputInt == 1){
            BrightonAPaperString = APaperArticlePieces[0];
        } else if (BrightonAOutputInt == 2){
            BrightonAPaperString = APaperArticlePieces[1];
        } else if (BrightonAOutputInt == 3){
            BrightonAPaperString = APaperArticlePieces[2];
        }

        if (BrightonBOutputInt == 1){
            BrightonBPaperString = BPaperArticlePieces[0];
        } else if (BrightonBOutputInt == 2){
            BrightonBPaperString = BPaperArticlePieces[1];
        } else if (BrightonBOutputInt == 3){
            BrightonBPaperString = BPaperArticlePieces[2];
        }

        if (BrightonCOutputInt == 1){
            BrightonCPaperString = CPaperArticlePieces[0];
        } else if (BrightonCOutputInt == 2){
            BrightonCPaperString = CPaperArticlePieces[1];
        } else if (BrightonCOutputInt == 3){
            BrightonCPaperString = CPaperArticlePieces[2];
        }
    }
    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt;
        //PAPER PIECING
        AngryNewspaper = BrightonAPaperString + "" + BorisAPaperString + "" + GuyAPaperString + "" + VitoAPaperString + "" + FranzAPaperString;
        FearfulNewspaper = BrightonBPaperString + "" + BorisBPaperString + "" + GuyBPaperString + "" + VitoBPaperString + "" + FranzBPaperString;
        CompassionateNewspaper = BrightonCPaperString + "" + BorisCPaperString + "" + GuyCPaperString + "" + VitoCPaperString + "" + FranzCPaperString;

        //For determining which paper to print when they're equal
        if (FearfulPaper == AngryPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = AngryNewspaper; //newspaperPrints[0]; //need to change this for the different outputs
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = FearfulNewspaper; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }   
        }

        if (FearfulPaper == CompassionatePaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = FearfulNewspaper; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = CompassionateNewspaper; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (CompassionatePaper == AngryPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = CompassionateNewspaper; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = AngryNewspaper; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }
        }

        if (CompassionatePaper == FearfulPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = CompassionateNewspaper; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = FearfulNewspaper; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
            }
        }

        if (AngryPaper == CompassionatePaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = AngryNewspaper; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }
            else{
                PlayerNewspaper = CompassionateNewspaper; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (AngryPaper == FearfulPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
            PlayerNewspaper = AngryNewspaper; //newspaperPrints[1];
            PlayerHeadline = newspaperHeadlines[1];
           }   
            else{
                PlayerNewspaper = FearfulNewspaper; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
            }    
        }
        //Brighton: 0,1,2 Boris: 3,4,5 Vito: 6,7,8 Guy: 9,10,11 Franz:, 12,13,14
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
