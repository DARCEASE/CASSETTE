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
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);            
        }
        else if (NovakDPOne.value == 2)
        {
            statusQuoPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);            
        }
        else if (NovakDPOne.value == 3)
        {
            tabloidPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
        }
    }
    public void NovakDropB() // WHO second dropdown for Novak
    {
        if (NovakDPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            muckrakerPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);            
        }
        else if (NovakDPTwo.value == 2)
        {
            statusQuoPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);            
        }
        else if (NovakDPTwo.value == 3)
        {
            tabloidPaper+=1;
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
        } 
    }
    public void NovakDropC()
    {
        if (NovakDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            muckrakerPaper+=1;
            NovakOutput1Bool = true;
            NovakOutput2Bool = false;
            NovakOutput3Bool = false;

            if (NovakOutput1Bool){
                PlayerNewspaper += MuckrakerArticlePieces[0];
            }
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);            
        }
        else if (NovakDPThree.value == 2)
        {
            statusQuoPaper+=1;
            NovakOutput1Bool = false;
            NovakOutput2Bool = true;
            NovakOutput3Bool = false;

            if (NovakOutput2Bool){
                PlayerNewspaper += MuckrakerArticlePieces[1];
            }
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);            
        }
        else if (NovakDPThree.value == 3)
        {
            tabloidPaper+=1;
            NovakOutput1Bool = false;
            NovakOutput2Bool = false;
            NovakOutput3Bool = true;

            if (NovakOutput3Bool){
                MuckrakerNewspaper += MuckrakerArticlePieces[2];
            }
            //Debug.Log("Pts: " + statusQuoPaper +", " + muckrakerPaper + ", " + tabloidPaper);
        }
    }

    //JIM AP: 3,4,5
    public void JimDropA() // JIM SENTENCE 1
    {
        if (JimDPOne.value == 1) 
        {
            muckrakerPaper+=1;
            Debug.Log("JIM. Drop 1 Opt 1");
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 1 Opt 2");
            statusQuoPaper+=1;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 1 Opt 3");
            tabloidPaper+=1;
        }
    }
    public void JimDropB() // JIM SENTENCE 2
    {
        if (JimDPTwo.value == 1) 
        {
            Debug.Log("JIM. Drop 2 Opt 1");
            muckrakerPaper+=1;
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 2 Opt 2");
            statusQuoPaper+=1;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 2 Opt 3");
            tabloidPaper+=1;
        }
    }
    public void JimDropC() // JIM SENTENCE 3 
    {
        if (JimDPThree.value == 1) 
        {
            //Debug.Log("JIM. Drop 3 Opt 1");
            muckrakerPaper+=1;
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
        }
        else if (JuliaDPOne.value == 2)
        {
            statusQuoPaper+=1;
            
        }
        else if (JuliaDPOne.value == 3)
        {
            tabloidPaper+=1;
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
        }
        else if (JuliaDPThree.value == 2)
        {
            statusQuoPaper+=1;
        }
        else if (JuliaDPThree.value == 3)
        {
            tabloidPaper+=1;
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
            
            if (MikeOutput1Bool){
                MuckrakerNewspaper += "" + MuckrakerArticlePieces[12];
            }
        }
        else if (MichaelDPOne.value == 2)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 2");
            statusQuoPaper+=1;
            
        }
        else if (MichaelDPOne.value == 3)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 3");
            tabloidPaper+=1;
            MikeOutput1Bool = false;
            MikeOutput3Bool = true;

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
        }
        else if (MichaelDPTwo.value == 2)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 2");
            statusQuoPaper+=1;
            MikeOutput2Bool = false;
        }
        else if (MichaelDPTwo.value == 3)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 3");
            tabloidPaper+=1;
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
            }
            else if (MichaelDPThree.value == 2)
            {
                statusQuoPaper+=1;
            }
            else if (MichaelDPThree.value == 3)
            {
                tabloidPaper+=1;
            }
        }

    //MAX AP: 9-11
    public void MaxDropA()
    {
        if (MaxDPOne.value == 1)
        {
            //Debug.Log("MAX. Drop 1 Opt 1");
            muckrakerPaper+=1;
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
        }
        else if (MaxDPTwo.value == 2)
        {
            //Debug.Log("MAX. Drop 2 Opt 2");
            statusQuoPaper+=1;
        }
        else if (MaxDPTwo.value == 3)
        {
            //Debug.Log("MAX. Drop 2 Opt 3");
            tabloidPaper+=1;
        }
    }
    public void MaxDropC()
    {
        if (MaxDPThree.value == 1)
        {
            Debug.Log("MAX. Drop 3 Opt 1");
            muckrakerPaper+=1;
        }
        else if (MaxDPThree.value == 2)
        {
            Debug.Log("MAX. Drop 3 Opt 2");
            statusQuoPaper+=1;
        }
        else if (MaxDPThree.value == 3)
        {
            Debug.Log("MAX. Drop 3 Opt 3");
            tabloidPaper+=1;
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
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }   
        }

        if (muckrakerPaper == tabloidPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = MuckrakerNewspaper;
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (tabloidPaper == statusQuoPaper){
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

        if (tabloidPaper == muckrakerPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = MuckrakerNewspaper;
                PlayerHeadline = newspaperHeadlines[0];
            }
        }

        if (statusQuoPaper == tabloidPaper){
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

        if (statusQuoPaper == muckrakerPaper){
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
        //Novak: 0,1,2 Jim: 3,4,5 Julia: 6,7,8 Michael: 9,10,11 Max:, 12,13,14
        //if they are not equal, it'll jump over here
        if (muckrakerPaper > tabloidPaper && muckrakerPaper > statusQuoPaper){
           PlayerNewspaper = MuckrakerNewspaper;
          
        }
        else if (statusQuoPaper > tabloidPaper && statusQuoPaper > muckrakerPaper){
            PlayerNewspaper = newspaperPrints[1];
            PlayerHeadline = newspaperHeadlines[1];
        }
        else if (tabloidPaper > muckrakerPaper && tabloidPaper > statusQuoPaper){
            PlayerNewspaper = newspaperPrints[2];
            PlayerHeadline = newspaperHeadlines[2];
        }
        finalNewspaper.text = PlayerNewspaper;
        finalHeadline.text = PlayerHeadline;
    }
}


