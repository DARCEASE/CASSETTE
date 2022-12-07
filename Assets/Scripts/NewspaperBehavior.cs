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
    public Text finalNewspaper, finalHeadline;
    
    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] newspaperPrints, MuckrakerArticlePieces;
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
            
            Char1SelectionDoneC = true;
            NovakOutput1Bool = true;
            ///*
            NovakOutput2Bool = false;
            NovakOutput3Bool = false;
            Debug.Log("JUMPED " + MuckrakerNewspaper);
            Debug.Log("1: " + NovakOutput1Bool + " 2: " + NovakOutput2Bool + " 3: " + NovakOutput3Bool);

            //*/            
        }
        else if (NovakDPThree.value == 2)
        {
            statusQuoPaper+=1;
            NovakOutput2Bool = true;
            Char1SelectionDoneC = true;
            //
            NovakOutput1Bool = false;
            NovakOutput3Bool = false;
            Debug.Log("FELL " + MuckrakerNewspaper);
            Debug.Log("1: " + NovakOutput1Bool + " 2: " + NovakOutput2Bool + " 3: " + NovakOutput3Bool);
            /*
            if (NovakOutput2Bool){
                PlayerNewspaper += MuckrakerArticlePieces[1];  
            }//*/
        }
        else if (NovakDPThree.value == 3)
        {
            tabloidPaper+=1;
            NovakOutput3Bool = true;
            Char1SelectionDoneC = true;
            ///*
            NovakOutput1Bool = false;
            NovakOutput2Bool = false;
            Debug.Log("PUSHED " + MuckrakerNewspaper);
            Debug.Log("1: " + NovakOutput1Bool + " 2: " + NovakOutput2Bool + " 3: " + NovakOutput3Bool);
            /*
            if (NovakOutput3Bool){
                MuckrakerNewspaper += MuckrakerArticlePieces[2];
            }*/
        }

        if (NovakOutput1Bool){
            MuckrakerNewspaper += MuckrakerArticlePieces[0];
        }
        if (NovakOutput2Bool){
            MuckrakerNewspaper += MuckrakerArticlePieces[1];
        }
        if (NovakOutput3Bool){
            MuckrakerNewspaper += MuckrakerArticlePieces[2];
        }
    }

    //JIM AP: 3,4,5
    public void JimDropA() // JIM SENTENCE 1, Selection A
    {
        if (JimDPOne.value == 1) 
        {
            muckrakerPaper+=1;
            Char2SelectionDoneA = true;
            Debug.Log("JIM. Drop 1 Opt 1");
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 1 Opt 2");
            statusQuoPaper+=1;
            Char2SelectionDoneA = true;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 1 Opt 3");
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
            Char2SelectionDoneC = true;

            JimOutput1Bool = true;
            JimOutput2Bool = false;
            JimOutput3Bool = false;

            if (JimOutput1Bool){
                MuckrakerNewspaper += MuckrakerArticlePieces[3];
            }
        }
        else if (JimDPThree.value == 2)
        {
            //Debug.Log("JIM. Drop 3 Opt 2");
            statusQuoPaper+=1;
            Char2SelectionDoneC = true;

            JimOutput1Bool = false;
            JimOutput2Bool = true;
            JimOutput3Bool = false;

            if (JimOutput2Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[4];
            }
        }
        else if (JimDPThree.value == 3)
        {
            //Debug.Log("JIM. Drop 3 Opt 3");
            tabloidPaper+=1;
            Char2SelectionDoneC = true;

            JimOutput1Bool = false;
            JimOutput2Bool = false;
            JimOutput3Bool = true;

            if (JimOutput2Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[5];
            }
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
            JuliaOutput1Bool = true;
            JuliaOutput2Bool = false;
            JuliaOutput3Bool = false;
            Char3SelectionDoneB = true;

            if (JuliaOutput1Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[6];
            }
        }
        else if (JuliaDPTwo.value == 2)
        {
            //Debug.Log("JULIA. Drop 2 Opt 2");
            statusQuoPaper+=1;
            JuliaOutput1Bool = false;
            JuliaOutput2Bool = true;
            JuliaOutput3Bool = false;
            Char3SelectionDoneB = true;

            if (JuliaOutput2Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[7];
            }
        }
        else if (JuliaDPTwo.value == 3)
        {
            //Debug.Log("JULIA. Drop 2 Opt 3");
            tabloidPaper+=1;
            JuliaOutput1Bool = false;
            JuliaOutput2Bool = false;
            JuliaOutput3Bool = true;
            Char3SelectionDoneB = true;

            if (JuliaOutput3Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[8];
            }
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
            MikeOutput1Bool = true;
            MikeOutput3Bool = false;
            Char5SelectionDoneA = true;
            
            if (MikeOutput1Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[12];
            }
        }
        else if (MichaelDPOne.value == 2)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 2");
            statusQuoPaper+=1;
            Char5SelectionDoneA = true;
        }
        else if (MichaelDPOne.value == 3)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 3");
            tabloidPaper+=1;
            MikeOutput1Bool = false;
            MikeOutput3Bool = true;
            Char5SelectionDoneA = true;

            if (MikeOutput3Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[14];
            }
        }
    }
    public void MichaelDropB()
    {
        if (MichaelDPTwo.value == 1)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 1");
            muckrakerPaper+=1;
            MikeOutput2Bool = false;
            Char5SelectionDoneB = true;
        }
        else if (MichaelDPTwo.value == 2)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 2");
            statusQuoPaper+=1;
            Char5SelectionDoneB = true;

            MikeOutput2Bool = false;
        }
        else if (MichaelDPTwo.value == 3)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 3");
            tabloidPaper+=1;
            Char5SelectionDoneB = true;

            MikeOutput2Bool = true;

             if (MikeOutput2Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[13];
            }
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
            Char4SelectionDoneA = true;

            MaxOutput1Bool = true;
            MaxOutput2Bool = false;
            MaxOutput3Bool = false;

             if (MaxOutput1Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[9];
            }
        }
        else if (MaxDPOne.value == 2)
        {
            //Debug.Log("MAX. Drop 1 Opt 2");
            statusQuoPaper+=1;
            Char4SelectionDoneA = true;

            MaxOutput1Bool = false;
            MaxOutput2Bool = true;
            MaxOutput3Bool = false;

             if (MaxOutput2Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[10];
            }
        }
        else if (MaxDPOne.value == 3)
        {
            //Debug.Log("MAX. Drop 1 Opt 3");
            tabloidPaper+=1;
            Char4SelectionDoneA = true;

            MaxOutput1Bool = false;
            MaxOutput2Bool = false;
            MaxOutput3Bool = true;

             if (MaxOutput3Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[11];
            }
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


