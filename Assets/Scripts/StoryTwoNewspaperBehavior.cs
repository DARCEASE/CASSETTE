using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTwoNewspaperBehavior : MonoBehaviour
{
   #region INITIALIZATIONS
    public string PlayerNewspaper, PlayerHeadline;
    public Text finalNewspaper, finalHeadline;
    
    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] newspaperPrints, newspaperHeadlines;

    // MAKE A VARIABLE FOR THE DROPDOWN ITSELF 
    public Dropdown BorisDPOne, BorisDPTwo, BorisDPThree;
    public Dropdown VitoDPOne, VitoDPTwo, VitoDPThree;
    public Dropdown GuyDPOne, GuyDPTwo, GuyDPThree;
    public Dropdown FranziskaDPOne, FranziskaDPTwo, FranziskaDPThree;
    public Dropdown BrightonDPOne, BrightonDPTwo, BrightonDPThree;

    //UI TEXT THAT WILL HOLD ALL STRING CHANGES
    [SerializeField] string[] jimNewspaperOptions;
    [SerializeField] string[] juliaNewspaperOptions;
    [SerializeField] string[] michaelNewspaperOptions;
    [SerializeField] string[] maxNewspaperOptions;
    [SerializeField] string[] novakNewspaperOptions;

    // establish all string variables that can be changed. and assign them on a UI text 
    [SerializeField] string[] novakInfoOptions;
    [SerializeField] string[] jimInfoOptions;
    [SerializeField] string[] juliaInfoOptions;
    [SerializeField] string[] michaelInfoOptions;
    [SerializeField] string[] maxInfoOptions;

    //Values
    [SerializeField] int FearfulPaper, AngryPaper, CompassionatePaper;
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

    //BORIS
    public void BorisDropA()
    {
        if (BorisDPOne.value == 1) // if you choose the first option for Novak Is.. 
        {  
            FearfulPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[0] = novakInfoOptions[0]; //NovakDPOne.options[0];
            
        }
        else if (BorisDPOne.value == 2)
        {
            AngryPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[0] = novakInfoOptions[1];
            
        }
        else if (BorisDPOne.value == 3)
        {
            CompassionatePaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[0] = novakInfoOptions[2];
        }
    }
    public void BorisDropB() // WHO second dropdown for Novak
    {
        if (BorisDPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            FearfulPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[1] = novakInfoOptions[3];
            
        }
        else if (BorisDPTwo.value == 2)
        {
            AngryPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[1] = novakInfoOptions[4];
            
        }
        else if (BorisDPTwo.value == 3)
        {
            CompassionatePaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[1] = novakInfoOptions[5]; 
        } 
    }
    public void BorisDropC()
    {
        if (BorisDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            FearfulPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[2] = novakInfoOptions[6];
            
        }
        else if (BorisDPThree.value == 2)
        {
            AngryPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[2] = novakInfoOptions[7];
            
        }
        else if (BorisDPThree.value == 3)
        {
            CompassionatePaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
            //novakNewspaperOptions[2] = novakInfoOptions[8];
        }
    }

    //VITO
    public void VitoDropA() // JIM SENTENCE 1
    {
        if (VitoDPOne.value == 1) 
        {
            FearfulPaper+=1;
            Debug.Log("JIM. Drop 1 Opt 1");
            //jimNewspaperOptions[0] = jimInfoOptions[0];
        }
        else if (VitoDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 1 Opt 2");
            //jimNewspaperOptions[0] = jimInfoOptions[1];
            AngryPaper+=1;
        }
        else if (VitoDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 1 Opt 3");
            //jimNewspaperOptions[0] = jimInfoOptions[2];
            CompassionatePaper+=1;
        }
    }
    public void VitoDropB() // JIM SENTENCE 2
    {
        if (VitoDPTwo.value == 1) 
        {
            Debug.Log("JIM. Drop 2 Opt 1");
            //jimNewspaperOptions[1] = jimInfoOptions[3];
            FearfulPaper+=1;
        }
        else if (VitoDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 2 Opt 2");
            //jimNewspaperOptions[1] = jimInfoOptions[4];
            AngryPaper+=1;
        }
        else if (VitoDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 2 Opt 3");
            //jimNewspaperOptions[1] = jimInfoOptions[5];
            CompassionatePaper+=1;
        }
    }
    public void VitoDropC() // JIM SENTENCE 3 
    {
        if (VitoDPThree.value == 1) 
        {
            Debug.Log("JIM. Drop 3 Opt 1");
            //jimNewspaperOptions[2] = jimInfoOptions[6];
            FearfulPaper+=1;
        }
        else if (VitoDPThree.value == 2)
        {
            Debug.Log("JIM. Drop 3 Opt 2");
            //jimNewspaperOptions[2] = jimInfoOptions[7];
            AngryPaper+=1;
        }
        else if (VitoDPThree.value == 3)
        {
            Debug.Log("JIM. Drop 3 Opt 3");
            //jimNewspaperOptions[2] = jimInfoOptions[8];
            CompassionatePaper+=1;
        } 
    }

    //GUY 
    public void GuyDropA()
    {
        if (GuyDPOne.value == 1) 
        {
            Debug.Log("JULIA. Drop 1 Opt 1");
            //juliaNewspaperOptions[0] = juliaInfoOptions[0];
            FearfulPaper+=1;
        }
        else if (GuyDPOne.value == 2)
        {
            Debug.Log("JULIA. Drop 1 Opt 2");
            //juliaNewspaperOptions[0] = juliaInfoOptions[1];
            AngryPaper+=1;
            
        }
        else if (GuyDPOne.value == 3)
        {
            Debug.Log("JULIA. Drop 1 Opt 3");
            //juliaNewspaperOptions[0] = juliaInfoOptions[2];
            CompassionatePaper+=1;
        }
    }
    public void GuyDropB()
    {
        if (GuyDPTwo.value == 1)
        {
            Debug.Log("JULIA. Drop 2 Opt 1");
            //juliaNewspaperOptions[1] = juliaInfoOptions[3];
            FearfulPaper+=1;
        }
        else if (GuyDPTwo.value == 2)
        {
            Debug.Log("JULIA. Drop 2 Opt 2");
            //juliaNewspaperOptions[1] = juliaInfoOptions[4];
            AngryPaper+=1;
        }
        else if (GuyDPTwo.value == 3)
        {
            Debug.Log("JULIA. Drop 2 Opt 3");
            //juliaNewspaperOptions[1] = juliaInfoOptions[5];
            CompassionatePaper+=1;
        }
    }
    public void GuyDropC()
    {
        if (GuyDPThree.value == 1)
        {
            FearfulPaper+=1;
            Debug.Log("JULIA. Drop 3 Opt 1");
            //juliaNewspaperOptions[2] = juliaInfoOptions[6]; 
        }
        else if (GuyDPThree.value == 2)
        {
            Debug.Log("JULIA. Drop 3 Opt 2");
            //juliaNewspaperOptions[2] = juliaInfoOptions[7];
            AngryPaper+=1;
        }
        else if (GuyDPThree.value == 3)
        {
            Debug.Log("JULIA. Drop 3 Opt 3");
            //juliaNewspaperOptions[2] = juliaInfoOptions[8];
            CompassionatePaper+=1;
        }
    }

    //FRANZ 
    public void FranziskaDropA()
    {
        if (FranziskaDPOne.value == 1)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 1");
            //ichaelNewspaperOptions[0] = michaelInfoOptions[0];
            FearfulPaper+=1;
        }
        else if (FranziskaDPOne.value == 2)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 2");
            //michaelNewspaperOptions[0] = michaelInfoOptions[1];
            AngryPaper+=1;
        }
        else if (FranziskaDPOne.value == 3)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 3");
            //michaelNewspaperOptions[0] = michaelInfoOptions[2];
            CompassionatePaper+=1;
        }
    }
    public void FranziskaDropB()
    {
        if (FranziskaDPTwo.value == 1)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 1");
            //michaelNewspaperOptions[1] = michaelInfoOptions[3];
            FearfulPaper+=1;
        }
        else if (FranziskaDPTwo.value == 2)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 2");
            //michaelNewspaperOptions[1] = michaelInfoOptions[4];
            AngryPaper+=1;
        }
        else if (FranziskaDPTwo.value == 3)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 3");
            //michaelNewspaperOptions[1] = michaelInfoOptions[5];
            CompassionatePaper+=1;
        }
    }
    public void FranziskaDropC()
    {
            if (FranziskaDPThree.value == 1)
            {
                Debug.Log("MICHAEL Drop 3 Opt 1");
                //michaelNewspaperOptions[2] = michaelInfoOptions[6];
                FearfulPaper+=1;
            }
            else if (FranziskaDPThree.value == 2)
            {
                Debug.Log("MICHAEL. Drop 3 Opt 2");
                //michaelNewspaperOptions[2] = michaelInfoOptions[7];
                AngryPaper+=1;
            }
            else if (FranziskaDPThree.value == 3)
            {
                Debug.Log("MICHAEL. Drop 3 Opt 3");
                //michaelNewspaperOptions[2] = michaelInfoOptions[8];
                CompassionatePaper+=1;
            }
        }

    //BRIGHTON BEACH MAN
    public void BrightonDropA()
    {
        if (BrightonDPOne.value == 1)
        {
            Debug.Log("MAX. Drop 1 Opt 1");
            //maxNewspaperOptions[0] = maxInfoOptions[0];
            FearfulPaper+=1;
        }
        else if (BrightonDPOne.value == 2)
        {
            Debug.Log("MAX. Drop 1 Opt 2");
            //michaelNewspaperOptions[0] = michaelInfoOptions[1];
            AngryPaper+=1;
        }
        else if (BrightonDPOne.value == 3)
        {
            Debug.Log("MAX. Drop 1 Opt 3");
            //michaelNewspaperOptions[0] = michaelInfoOptions[2];
            CompassionatePaper+=1;
        }
    }
    public void BrightonDropB()
    {
        if (BrightonDPTwo.value == 1)
        {
            Debug.Log("MAX. Drop 2 Opt 1");
            //michaelNewspaperOptions[1] = michaelInfoOptions[3];
            FearfulPaper+=1;
        }
        else if (BrightonDPTwo.value == 2)
        {
            Debug.Log("MAX. Drop 2 Opt 2");
            //michaelNewspaperOptions[1] = michaelInfoOptions[4];
            AngryPaper+=1;
        }
        else if (BrightonDPTwo.value == 3)
        {
            Debug.Log("MAX. Drop 2 Opt 3");
            //michaelNewspaperOptions[1] = michaelInfoOptions[5];
            CompassionatePaper+=1;
        }
    }
    public void BrightonDropC()
    {
        if (BrightonDPThree.value == 1)
        {
            Debug.Log("MAX. Drop 3 Opt 1");
            //michaelNewspaperOptions[2] = michaelInfoOptions[6];
            FearfulPaper+=1;
        }
        else if (BrightonDPThree.value == 2)
        {
            Debug.Log("MAX. Drop 3 Opt 2");
            //michaelNewspaperOptions[2] = michaelInfoOptions[7];
            AngryPaper+=1;
        }
        else if (BrightonDPThree.value == 3)
        {
            Debug.Log("MAX. Drop 3 Opt 3");
            //michaelNewspaperOptions[2] = michaelInfoOptions[8];
            CompassionatePaper+=1;
        }
    }
    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt; 
        
        //For determining which paper to print when they're equal
        if (FearfulPaper == AngryPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = newspaperPrints[0]; //need to change this for the different outputs
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }   
        }

        if (FearfulPaper == CompassionatePaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (CompassionatePaper == AngryPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }
        }

        if (CompassionatePaper == FearfulPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
            }
        }

        if (AngryPaper == CompassionatePaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }
            else{
                PlayerNewspaper = newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (AngryPaper == FearfulPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
            PlayerNewspaper = newspaperPrints[1];
            PlayerHeadline = newspaperHeadlines[1];
           }   
            else{
                PlayerNewspaper = newspaperPrints[0];
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
        finalNewspaper.text = PlayerNewspaper + "Add this";
        finalHeadline.text = PlayerHeadline;

    }
}
