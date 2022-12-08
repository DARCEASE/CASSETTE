using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//PURPOSE:to display the submitted newspaper article based on dropdown choices (detect selections in drop down menus)
// USAGE: Place this on an empty gameobject called DropdownController  (works almsot like button controller scripts youve done) - when you program stuff, make functions for specific actions
// usage cont: now when you have that working, head into the drop down youre refering to, go to where it says OnValuesChanged() - drag in the GO with this script onit and find the function you want it to refer to 
// cont cont: now, when you select a specific dropdown, it should do something. 
public class NewspaperBehavior : MonoBehaviour
{
#region INITIALIZATIONS
    public string PlayerNewspaper, MuckrakerNewspaper, StatusQuoNewspaper, TabloidNewspaper, PlayerHeadline;
    
    //All paper holding strings
    string NovakMuckString, NovakSQString, NovakTabloidString;
    string JimMuckString, JimSQString, JimTabloidString;
    string JuliaMuckString, JuliaSQString, JuliaTabloidString;
    string MaxMuckString, MaxSQString, MaxTabloidString;
    string MichaelMuckString, MichaelSQString, MichaelTabloidString;

    public Text finalNewspaper, finalHeadline;
    [SerializeField] int NovakOutputInt, JimOutputInt, JuliaOutputInt, MaxOutputInt, MikeOutputInt;
    
    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] newspaperPrints, MuckrakerArticlePieces, SQArticlePieces, TabloidArticlePieces;
    [SerializeField] string[] newspaperHeadlines;
    // MAKE A VARIABLE FOR THE DROPDOWN ITSELF 
    public Dropdown NovakDPOne, NovakDPTwo, NovakDPThree;
    public Dropdown JimDPOne, JimDPTwo, JimDPThree;
    public Dropdown JuliaDPOne, JuliaDPTwo, JuliaDPThree;
    public Dropdown MichaelDPOne, MichaelDPTwo, MichaelDPThree;
    public Dropdown MaxDPOne, MaxDPTwo, MaxDPThree;
    
    //Keeps track of which dropsdowns are complete. Broad so it can be used in future NPB scripts.
    //These will be accessed by CharacterCompleteCheck so it MUST BE PUBLIC!
    public bool Char1SelectionDoneA, Char1SelectionDoneB, Char1SelectionDoneC; 
    public bool Char2SelectionDoneA, Char2SelectionDoneB, Char2SelectionDoneC;
    public bool Char3SelectionDoneA, Char3SelectionDoneB, Char3SelectionDoneC;
    public bool Char4SelectionDoneA, Char4SelectionDoneB, Char4SelectionDoneC;
    public bool Char5SelectionDoneA, Char5SelectionDoneB, Char5SelectionDoneC;
    bool NovakOutput1Bool, NovakOutput2Bool, NovakOutput3Bool, JuliaOutput1Bool, JuliaOutput2Bool, JuliaOutput3Bool, JimOutput1Bool, JimOutput2Bool, JimOutput3Bool, MaxOutput1Bool, MaxOutput2Bool, MaxOutput3Bool, MikeOutput1Bool, MikeOutput2Bool, MikeOutput3Bool; //Novak is 0, 1, 2 of AP
    //Values
    [SerializeField] int muckrakerPaper, tabloidPaper, statusQuoPaper;
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

    //NOVAK AP: 0,1,2
    public void NovakDropA()
    {
        if (NovakDPOne.value == 1) // if you choose the first option for Novak Is.. 
        {  
            muckrakerPaper+=1;
            Char1SelectionDoneA = true;
        }
        else if (NovakDPOne.value == 2)
        {
            statusQuoPaper+=1;
            Char1SelectionDoneA = true;
        }
        else if (NovakDPOne.value == 3)
        {
            tabloidPaper+=1;
            Char1SelectionDoneA = true;
        }
    }
    public void NovakDropB() // WHO second dropdown for Novak
    {
        if (NovakDPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            muckrakerPaper+=1;
            Char1SelectionDoneB = true;
        }
        else if (NovakDPTwo.value == 2)
        {
            statusQuoPaper+=1;
            Char1SelectionDoneB = true;
        }
        else if (NovakDPTwo.value == 3)
        {
            tabloidPaper+=1;
            Char1SelectionDoneB = true;
        } 
    }
    public void NovakDropC()
    {
        if (NovakDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            muckrakerPaper+=1;
            NovakOutputInt = 1;            
            Char1SelectionDoneC = true;
            Debug.Log("JUMPED " + MuckrakerNewspaper);
            Debug.Log("1: " + NovakOutput1Bool + " 2: " + NovakOutput2Bool + " 3: " + NovakOutput3Bool);           
        }
        else if (NovakDPThree.value == 2)
        {
            statusQuoPaper+=1;
            NovakOutputInt = 2;
            Char1SelectionDoneC = true;
            Debug.Log("FELL " + MuckrakerNewspaper);
            Debug.Log("1: " + NovakOutput1Bool + " 2: " + NovakOutput2Bool + " 3: " + NovakOutput3Bool);
        }
        else if (NovakDPThree.value == 3)
        {
            tabloidPaper+=1;
            Char1SelectionDoneC = true;
            Debug.Log("PUSHED " + MuckrakerNewspaper);
            Debug.Log("1: " + NovakOutput1Bool + " 2: " + NovakOutput2Bool + " 3: " + NovakOutput3Bool);
        }

        //SHould change bools into ints to make it easier and clean things up.
        if (NovakOutputInt == 1){
            NovakMuckString = MuckrakerArticlePieces[0];
        } else if (NovakOutputInt == 2){
            NovakMuckString = MuckrakerArticlePieces[1];
        } else if (NovakOutputInt == 3){
            NovakMuckString = MuckrakerArticlePieces[2];
        }
    }

    //JIM AP: 3,4,5
    public void JimDropA() // JIM SENTENCE 1, Selection A
    {
        if (JimDPOne.value == 1) 
        {
            muckrakerPaper+=1;
            Char2SelectionDoneA = true;
        }
        else if (JimDPOne.value == 2)
        {
            statusQuoPaper+=1;
            Char2SelectionDoneA = true;
        }
        else if (JimDPOne.value == 3)
        {
            tabloidPaper+=1;
            Char2SelectionDoneA = true;
        }
    }
    
    public void JimDropB() // JIM SENTENCE 2, Selection B
    {
        if (JimDPTwo.value == 1) 
        {
            Debug.Log("JIM. Drop 2 Opt 1");
            muckrakerPaper+=1;
            Char2SelectionDoneB = true;
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 2 Opt 2");
            statusQuoPaper+=1;
            Char2SelectionDoneB = true;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 2 Opt 3");
            tabloidPaper+=1;
            Char2SelectionDoneB = true;
        }
    }
    public void JimDropC() // JIM SENTENCE 3 
    {
        if (JimDPThree.value == 1) 
        {
            //Debug.Log("JIM. Drop 3 Opt 1");
            muckrakerPaper+=1;
            JimOutputInt = 1;
            Char2SelectionDoneC = true;
        }
        else if (JimDPThree.value == 2)
        {
            //Debug.Log("JIM. Drop 3 Opt 2");
            statusQuoPaper+=1;
            Char2SelectionDoneC = true;
            JimOutputInt = 2;
        }
        else if (JimDPThree.value == 3)
        {
            //Debug.Log("JIM. Drop 3 Opt 3");
            tabloidPaper+=1;
            JimOutputInt = 3;
            Char2SelectionDoneC = true;
        }

        if (JimOutputInt == 1){
            JimMuckString = MuckrakerArticlePieces[3];
        } else if (JimOutputInt == 2){
            JimMuckString = MuckrakerArticlePieces[4];
        } else if (JimOutputInt == 3){
            JimMuckString = MuckrakerArticlePieces[5];
        }
    }

    //JULIA AP:6,7,8
    public void JuliaDropA()
    {
        if (JuliaDPOne.value == 1) 
        {
            muckrakerPaper+=1;
            Char3SelectionDoneA = true;
        }
        else if (JuliaDPOne.value == 2)
        {
            statusQuoPaper+=1;
            Char3SelectionDoneA = true;
        }
        else if (JuliaDPOne.value == 3)
        {
            tabloidPaper+=1;
            Char3SelectionDoneA = true;
        }
    }
    public void JuliaDropB()
    {
        if (JuliaDPTwo.value == 1)
        {
            //Debug.Log("JULIA. Drop 2 Opt 1");
            muckrakerPaper+=1;
            Char3SelectionDoneB = true;
            JuliaOutputInt = 1;
        }
        else if (JuliaDPTwo.value == 2)
        {
            //Debug.Log("JULIA. Drop 2 Opt 2");
            statusQuoPaper+=1;
            Char3SelectionDoneB = true;
            JuliaOutputInt = 2;
        }
        else if (JuliaDPTwo.value == 3)
        {
            //Debug.Log("JULIA. Drop 2 Opt 3");
            Char3SelectionDoneB = true;
            JuliaOutputInt = 3;
        }

        if (JuliaOutputInt == 1){
            JuliaMuckString = MuckrakerArticlePieces[6];
        } else if (JuliaOutputInt == 2){
            JuliaMuckString = MuckrakerArticlePieces[7];
        } else if (JimOutputInt == 3){
            JuliaMuckString = MuckrakerArticlePieces[8];
        }
    }
    public void JuliaDropC()
    {
        if (JuliaDPThree.value == 1)
        {
            muckrakerPaper+=1;
            Char3SelectionDoneC = true;
        }
        else if (JuliaDPThree.value == 2)
        {
            statusQuoPaper+=1;
            Char3SelectionDoneC = true;
        }
        else if (JuliaDPThree.value == 3)
        {
            tabloidPaper+=1;
            Char3SelectionDoneC = true;
        }
    }

    //MICHAEL AP: 12-14
    public void MichaelDropA()
    {
        if (MichaelDPOne.value == 1)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 1");
            muckrakerPaper+=1;
            MikeOutputInt = 1;
            Char5SelectionDoneA = true;
        }
        else if (MichaelDPOne.value == 2)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 2");
            statusQuoPaper+=1;
            MikeOutputInt = 2;
            Char5SelectionDoneA = true;
        }
        else if (MichaelDPOne.value == 3)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 3");
            tabloidPaper+=1;
            MikeOutputInt = 3;
            Char5SelectionDoneA = true;
        }

        
        if (MikeOutputInt == 1){
            MichaelMuckString = MuckrakerArticlePieces[12];
        } else if (MikeOutputInt == 2){
            MichaelMuckString = MuckrakerArticlePieces[13];
        } else if (MikeOutputInt == 3){
            MichaelMuckString = MuckrakerArticlePieces[14];
        }
    }
    public void MichaelDropB()
    {
        if (MichaelDPTwo.value == 1)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 1");
            muckrakerPaper+=1;
            Char5SelectionDoneB = true;
        }
        else if (MichaelDPTwo.value == 2)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 2");
            statusQuoPaper+=1;
            Char5SelectionDoneB = true;
        }
        else if (MichaelDPTwo.value == 3)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 3");
            tabloidPaper+=1;
            Char5SelectionDoneB = true;

        }
    }
    public void MichaelDropC()
    {
            if (MichaelDPThree.value == 1)
            {
                muckrakerPaper+=1;
                Char5SelectionDoneC = true;
            }
            else if (MichaelDPThree.value == 2)
            {
                statusQuoPaper+=1;
                Char5SelectionDoneC = true;
            }
            else if (MichaelDPThree.value == 3)
            {
                tabloidPaper+=1;
                Char5SelectionDoneC = true;
            }
        }

    //MAX AP: 9-11
    public void MaxDropA()
    {
        if (MaxDPOne.value == 1)
        {
            //Debug.Log("MAX. Drop 1 Opt 1");
            muckrakerPaper+=1;
            MaxOutputInt = 1;
            Char4SelectionDoneA = true;
        }
        else if (MaxDPOne.value == 2)
        {
            //Debug.Log("MAX. Drop 1 Opt 2");
            statusQuoPaper+=1;
            MaxOutputInt = 2;
            Char4SelectionDoneA = true;
        }
        else if (MaxDPOne.value == 3)
        {
            //Debug.Log("MAX. Drop 1 Opt 3");
            tabloidPaper+=1;
            MaxOutputInt = 3;
            Char4SelectionDoneA = true;
        }

        
        if (MaxOutputInt == 1){
            MaxMuckString = MuckrakerArticlePieces[9];
        } else if (MaxOutputInt == 2){
            MaxMuckString = MuckrakerArticlePieces[10];
        } else if (MikeOutputInt == 3){
            MaxMuckString = MuckrakerArticlePieces[11];
        }
    }
    public void MaxDropB()
    {
        if (MaxDPTwo.value == 1)
        {
            //Debug.Log("MAX. Drop 2 Opt 1");
            muckrakerPaper+=1;
            Char4SelectionDoneB = true;
        }
        else if (MaxDPTwo.value == 2)
        {
            //Debug.Log("MAX. Drop 2 Opt 2");
            statusQuoPaper+=1;
            Char4SelectionDoneB = true;
        }
        else if (MaxDPTwo.value == 3)
        {
            //Debug.Log("MAX. Drop 2 Opt 3");
            tabloidPaper+=1;
            Char4SelectionDoneB = true;
        }
    }
    public void MaxDropC()
    {
        if (MaxDPThree.value == 1)
        {
            Debug.Log("MAX. Drop 3 Opt 1");
            muckrakerPaper+=1;
            Char4SelectionDoneC = true;

        }
        else if (MaxDPThree.value == 2)
        {
            Debug.Log("MAX. Drop 3 Opt 2");
            statusQuoPaper+=1;
            Char4SelectionDoneC = true;

        }
        else if (MaxDPThree.value == 3)
        {
            Debug.Log("MAX. Drop 3 Opt 3");
            tabloidPaper+=1;
            Char4SelectionDoneC = true;
        }
    }

    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt;
        //PAPER PIECING
        MuckrakerNewspaper = NovakMuckString + "" + JuliaMuckString + "" + JimMuckString + "" + MaxMuckString + "" + MichaelMuckString;
        //Value Check
        if (muckrakerPaper == statusQuoPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = MuckrakerNewspaper;
                //PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = newspaperPrints[1];
                //PlayerHeadline = newspaperHeadlines[1];
            }   
        }

        if (muckrakerPaper == tabloidPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = MuckrakerNewspaper;
                //PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                //PlayerNewspaper = newspaperPrints[2];
                //PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (tabloidPaper == statusQuoPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                //PlayerNewspaper = newspaperPrints[2];
                //PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                //PlayerNewspaper = newspaperPrints[1];
                //PlayerHeadline = newspaperHeadlines[1];
            }
        }

        if (tabloidPaper == muckrakerPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                //PlayerNewspaper = newspaperPrints[2];
                //PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                //PlayerNewspaper = MuckrakerNewspaper;
                //PlayerHeadline = newspaperHeadlines[0];
            }
        }

        if (statusQuoPaper == tabloidPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                //PlayerNewspaper = newspaperPrints[1];
                //PlayerHeadline = newspaperHeadlines[1];
            }
            else{
                //PlayerNewspaper = newspaperPrints[2];
                //PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (statusQuoPaper == muckrakerPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
            //PlayerNewspaper = newspaperPrints[1];
            //PlayerHeadline = newspaperHeadlines[1];
           }   
            else{
                //PlayerNewspaper = newspaperPrints[0];
                //PlayerHeadline = newspaperHeadlines[0];
            }    
        }
        //Novak: 0,1,2 Jim: 3,4,5 Julia: 6,7,8 Michael: 9,10,11 Max:, 12,13,14
        //if they are not equal, it'll jump over here
        if (muckrakerPaper > tabloidPaper && muckrakerPaper > statusQuoPaper){
           PlayerNewspaper = MuckrakerNewspaper;
          
        }
        else if (statusQuoPaper > tabloidPaper && statusQuoPaper > muckrakerPaper){
            //PlayerNewspaper = newspaperPrints[1];
            //PlayerHeadline = newspaperHeadlines[1];
        }
        else if (tabloidPaper > muckrakerPaper && tabloidPaper > statusQuoPaper){
            //PlayerNewspaper = newspaperPrints[2];
            //PlayerHeadline = newspaperHeadlines[2];
        }
        finalNewspaper.text = PlayerNewspaper;
        finalHeadline.text = PlayerHeadline;
    }
}


