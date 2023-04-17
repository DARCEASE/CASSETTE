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
    
    //Audience Feedback Script
    public AudienceFeedbackScript AFS;

    //All paper holding strings
    string NovakMuckString, NovakSQString, NovakTabloidString;
    string JimMuckString, JimSQString, JimTabloidString;
    string JuliaMuckString, JuliaSQString, JuliaTabloidString;
    string MaxMuckString, MaxSQString, MaxTabloidString;
    string MichaelMuckString, MichaelSQString, MichaelTabloidString;

    public Text finalNewspaper, finalHeadline;
    [SerializeField] int NovakOutputInt, JimOutputInt, JuliaOutputInt, MaxOutputInt, MikeOutputInt;
    [SerializeField] int NovakSQOutputInt, JimSQOutputInt, JuliaSQOutputInt, MaxSQOutputInt, MikeSQOutputInt;
    [SerializeField] int NovakTabOutputInt, JimTabOutputInt, JuliaTabOutputInt, MaxTabOutputInt, MikeTabOutputInt;


    
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

    //Side Article
    [SerializeField] SideArticleScript SAS;
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
            NovakSQOutputInt = 1;
            Char1SelectionDoneA = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (NovakDPOne.value == 2)
        {
            statusQuoPaper+=1;
            NovakSQOutputInt = 2;
            Char1SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal -= AFS.ratingNum;    
        }
        else if (NovakDPOne.value == 3)
        {
            tabloidPaper+=1;
            NovakSQOutputInt = 3;
            Char1SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.unbiasedVal -= AFS.ratingNum;
        }

        //SQ
        if (NovakSQOutputInt == 1){
            NovakSQString = SQArticlePieces[0];

        } else if (NovakSQOutputInt == 2){
            NovakSQString = SQArticlePieces[1];
        } else if (NovakSQOutputInt == 3){
            NovakSQString = SQArticlePieces[2];
        }
    }
    public void NovakDropB() // WHO second dropdown for Novak
    {
        if (NovakDPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            muckrakerPaper+=1;
            Char1SelectionDoneB = true;

            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
        }
        else if (NovakDPTwo.value == 2)
        {
            statusQuoPaper+=1;
            Char1SelectionDoneB = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (NovakDPTwo.value == 3)
        {
            tabloidPaper+=1;
            Char1SelectionDoneB = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
        } 
    }
    public void NovakDropC()
    {
        if (NovakDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            muckrakerPaper+=1;
            NovakOutputInt = 1;
            NovakTabOutputInt = 1;
            Char1SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
        }
        else if (NovakDPThree.value == 2)
        {
            statusQuoPaper+=1;
            NovakOutputInt = 2;
            NovakTabOutputInt = 2;
            Char1SelectionDoneC = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (NovakDPThree.value == 3)
        {
            tabloidPaper+=1;
            NovakOutputInt = 3;
            NovakTabOutputInt = 3;
            Char1SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
            SAS.sideArt1 += 25;
        }

        //SHould change bools into ints to make it easier and clean things up.
        //Muckraker
        if (NovakOutputInt == 1){
            NovakMuckString = MuckrakerArticlePieces[0];
        } else if (NovakOutputInt == 2){
            NovakMuckString = MuckrakerArticlePieces[1];
        } else if (NovakOutputInt == 3){
            NovakMuckString = MuckrakerArticlePieces[2];
        }

        //Tab
        if (NovakTabOutputInt == 1){
            NovakTabloidString = TabloidArticlePieces[0];
        } else if (NovakTabOutputInt == 2){
            NovakTabloidString = TabloidArticlePieces[1];
        } else if (NovakTabOutputInt == 3){
            NovakTabloidString = TabloidArticlePieces[2];
        }
    }

    //JIM AP: 3,4,5
    public void JimDropA() // JIM SENTENCE 1, Selection A
    {
        if (JimDPOne.value == 1) 
        {
            muckrakerPaper+=1;
            JimTabOutputInt = 1;
            Char2SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            SAS.sideArt1 += 25;
        }
        else if (JimDPOne.value == 2)
        {
            statusQuoPaper+=1;
            JimTabOutputInt = 2;
            Char2SelectionDoneA = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (JimDPOne.value == 3)
        {
            tabloidPaper+=1;
            JimTabOutputInt = 3;
            Char2SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
        }

        //Tabloid
        if (JimTabOutputInt == 1){
            JimTabloidString = TabloidArticlePieces[3];
        } else if (JimTabOutputInt == 2){
            JimTabloidString = TabloidArticlePieces[4];
        } else if (JimTabOutputInt == 3){
            JimTabloidString = TabloidArticlePieces[5];
        }
    }
    
    public void JimDropB() // JIM SENTENCE 2, Selection B
    {
        if (JimDPTwo.value == 1) 
        {
            Debug.Log("JIM. Drop 2 Opt 1");
            muckrakerPaper+=1;
            JimSQOutputInt = 1;
            Char2SelectionDoneB = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;        
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 2 Opt 2");
            statusQuoPaper+=1;
            JimSQOutputInt = 2;
            Char2SelectionDoneB = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 2 Opt 3");
            tabloidPaper+=1;
            JimSQOutputInt = 3;
            Char2SelectionDoneB = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
        }

        //SQ
         if (JimSQOutputInt == 1){
            JimSQString = SQArticlePieces[3];
        } else if (JimSQOutputInt == 2){
            JimSQString = SQArticlePieces[4];
        } else if (JimSQOutputInt == 3){
            JimSQString = SQArticlePieces[5];
        }
    }
    public void JimDropC() // JIM SENTENCE 3 
    {
        if (JimDPThree.value == 1) 
        {
            muckrakerPaper+=1;
            JimOutputInt = 1;
            Char2SelectionDoneC = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (JimDPThree.value == 2)
        {
            statusQuoPaper+=1;
            Char2SelectionDoneC = true;
            JimOutputInt = 2;
            //Feedback Vals
            AFS.entertainingVal -= AFS.ratingNum;
            SAS.sideArt4 += 20;
        }
        else if (JimDPThree.value == 3)
        {
            //Debug.Log("JIM. Drop 3 Opt 3");
            tabloidPaper+=1;
            JimOutputInt = 3;
            Char2SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
            AFS.unbiasedVal -= AFS.ratingNum;
            SAS.sideArt1 += 25;
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
            JuliaSQOutputInt = 1;
            Char3SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (JuliaDPOne.value == 2)
        {
            statusQuoPaper+=1;
            JuliaSQOutputInt = 2;
            Char3SelectionDoneA = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
        }
        else if (JuliaDPOne.value == 3)
        {
            tabloidPaper+=1;
            JuliaSQOutputInt = 3;
            Char3SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
            AFS.unbiasedVal -= AFS.ratingNum;
        }

         if (JuliaSQOutputInt == 1){
            JuliaSQString = SQArticlePieces[6];
        } else if (JuliaSQOutputInt == 2){
            JuliaSQString = SQArticlePieces[7];
        } else if (JuliaSQOutputInt == 3){
            JuliaSQString = SQArticlePieces[8];
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
            //Feedback Vals
            AFS.entertainingVal -= AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (JuliaDPTwo.value == 2)
        {
            //Debug.Log("JULIA. Drop 2 Opt 2");
            statusQuoPaper+=1;
            Char3SelectionDoneB = true;
            JuliaOutputInt = 2;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
            SAS.sideArt4 += 20;
        }
        else if (JuliaDPTwo.value == 3)
        {
            //Debug.Log("JULIA. Drop 2 Opt 3");
            tabloidPaper +=1;
            Char3SelectionDoneB = true;
            JuliaOutputInt = 3;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
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
            JuliaTabOutputInt = 1;
            Char3SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
        }
        else if (JuliaDPThree.value == 2)
        {
            statusQuoPaper+=1;
            JuliaTabOutputInt = 2;
            Char3SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal -= AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (JuliaDPThree.value == 3)
        {
            tabloidPaper+=1;
            JuliaTabOutputInt = 3;
            Char3SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }

        if (JuliaTabOutputInt  == 1){
            JuliaTabloidString = TabloidArticlePieces[6];
        } else if (JuliaTabOutputInt == 2){
            JuliaTabloidString = TabloidArticlePieces[7];
        } else if (JuliaTabOutputInt == 3){
            JuliaTabloidString = TabloidArticlePieces[8];
        }
    }

    //MICHAEL AP: 12-14
    public void MichaelDropA()
    {
        if (MichaelDPOne.value == 1)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 1");
            muckrakerPaper+=1;
            MikeTabOutputInt = 1;
            MikeSQOutputInt = 1;
            MikeOutputInt = 1;
            Char5SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (MichaelDPOne.value == 2)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 2");
            statusQuoPaper+=1;
            MikeTabOutputInt = 2;
            MikeSQOutputInt = 2;
            MikeOutputInt = 2;
            Char5SelectionDoneA = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
            SAS.sideArt3 += 21;
        }
        else if (MichaelDPOne.value == 3)
        {
            //Debug.Log("MICHAEL. Drop 1 Opt 3");
            tabloidPaper+=1;
            MikeTabOutputInt = 3;
            MikeSQOutputInt = 3;
            MikeOutputInt = 3;
            Char5SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
            SAS.sideArt2 += 65;
        }

        if (MikeOutputInt == 1){
            MichaelMuckString = MuckrakerArticlePieces[12];
        } else if (MikeOutputInt == 2){
            MichaelMuckString = MuckrakerArticlePieces[13];
        } else if (MikeOutputInt == 3){
            MichaelMuckString = MuckrakerArticlePieces[14];
        }

        //SQ
        if (MikeSQOutputInt  == 1){
            MichaelSQString = SQArticlePieces[12];
        } else if (MikeSQOutputInt == 2){
            MichaelSQString = SQArticlePieces[13];
        } else if (MikeSQOutputInt == 3){
            MichaelSQString = SQArticlePieces[14];
        }

        //Tabloid
        if (MikeTabOutputInt  == 1){
            MichaelTabloidString = TabloidArticlePieces[12];
        } else if (MikeTabOutputInt == 2){
            MichaelTabloidString = TabloidArticlePieces[13];
        } else if (MikeTabOutputInt == 3){
            MichaelTabloidString = TabloidArticlePieces[14];
        }
    }
    public void MichaelDropB()
    {
        if (MichaelDPTwo.value == 1)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 1");
            muckrakerPaper+=1;
            Char5SelectionDoneB = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.unbiasedVal -= AFS.ratingNum;
        }
        else if (MichaelDPTwo.value == 2)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 2");
            statusQuoPaper+=1;
            Char5SelectionDoneB = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (MichaelDPTwo.value == 3)
        {
            //Debug.Log("MICHAEL. Drop 2 Opt 3");
            tabloidPaper+=1;
            Char5SelectionDoneB = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
            SAS.sideArt2 += 35;
        }
    }
    public void MichaelDropC()
    {
        if (MichaelDPThree.value == 1)
        {
            muckrakerPaper+=1;
            Char5SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
            SAS.sideArt4 += 20;
        }
        else if (MichaelDPThree.value == 2)
        {
            statusQuoPaper+=1;
            Char5SelectionDoneC = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (MichaelDPThree.value == 3)
        {
            tabloidPaper+=1;
            Char5SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
        }
    }

    //MAX AP: 9-11
    public void MaxDropA()
    {
        if (MaxDPOne.value == 1)
        {
            muckrakerPaper+=1;
            MaxSQOutputInt = 1;
            MaxOutputInt = 1;
            Char4SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            SAS.sideArt4 += 20;

        }
        else if (MaxDPOne.value == 2)
        {
            statusQuoPaper+=1;
            MaxSQOutputInt = 2;
            MaxOutputInt = 2;
            Char4SelectionDoneA = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (MaxDPOne.value == 3)
        {
            tabloidPaper+=1;
            MaxSQOutputInt = 3;
            MaxOutputInt = 3;
            Char4SelectionDoneA = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
        }
        
        if (MaxOutputInt == 1){
            MaxMuckString = MuckrakerArticlePieces[9];
        } else if (MaxOutputInt == 2){
            MaxMuckString = MuckrakerArticlePieces[10];
        } else if (MikeOutputInt == 3){
            MaxMuckString = MuckrakerArticlePieces[11];
        }

        //SQ
        if (MaxSQOutputInt == 1){
            MaxSQString = SQArticlePieces[9];
        } else if (MaxSQOutputInt == 2){
            MaxSQString = SQArticlePieces[10];
        } else if (MaxSQOutputInt == 3){
            MaxSQString = SQArticlePieces[11];
        }

    }
    public void MaxDropB()
    {
        if (MaxDPTwo.value == 1)
        {
            //Debug.Log("MAX. Drop 2 Opt 1");
            muckrakerPaper+=1;
            MaxTabOutputInt = 1;
            Char4SelectionDoneB = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.unbiasedVal -= AFS.ratingNum;
        }
        else if (MaxDPTwo.value == 2)
        {
            //Debug.Log("MAX. Drop 2 Opt 2");
            statusQuoPaper+=1;
            MaxTabOutputInt = 2;
            Char4SelectionDoneB = true;
            //Feedback Vals
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
            SAS.sideArt3 += 21;
        }
        else if (MaxDPTwo.value == 3)
        {
            //Debug.Log("MAX. Drop 2 Opt 3");
            tabloidPaper+=1;
            MaxTabOutputInt = 3;
            Char4SelectionDoneB = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
        }

        if (MaxTabOutputInt == 1){
            MaxTabloidString = TabloidArticlePieces[9];
        } else if (MaxTabOutputInt == 2){
            MaxTabloidString = TabloidArticlePieces[10];
        } else if (MaxTabOutputInt == 3){
            MaxTabloidString = TabloidArticlePieces[11];
        }

    }
    public void MaxDropC()
    {
        if (MaxDPThree.value == 1)
        {
            Debug.Log("MAX. Drop 3 Opt 1");
            muckrakerPaper+=1;
            Char4SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal += AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
        }
        else if (MaxDPThree.value == 2)
        {
            Debug.Log("MAX. Drop 3 Opt 2");
            statusQuoPaper+=1;
            Char4SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal -= AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
            AFS.unbiasedVal += AFS.ratingNum;
            SAS.sideArt3 += 21;
        }
        else if (MaxDPThree.value == 3)
        {
            Debug.Log("MAX. Drop 3 Opt 3");
            tabloidPaper+=1;
            Char4SelectionDoneC = true;
            //Feedback Vals
            AFS.entertainingVal += AFS.ratingNum;
            AFS.credibleVal -= AFS.ratingNum;
        }
    }

    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt;
        //PAPER PIECING
        MuckrakerNewspaper = NovakMuckString + "\n" + JuliaMuckString + "\n" + JimMuckString + "\n" + MaxMuckString + "\n" + MichaelMuckString;
        StatusQuoNewspaper = NovakSQString + "\n" + JuliaSQString + "\n" + JimSQString + "\n" + MaxSQString + "\n" + MichaelSQString;
        TabloidNewspaper = NovakTabloidString + "\n" + JuliaTabloidString + "\n" + JimTabloidString + "\n" + MaxTabloidString + "\n" + MichaelTabloidString;


        //Value Check
        if (muckrakerPaper == statusQuoPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = MuckrakerNewspaper;
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = StatusQuoNewspaper;
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
                PlayerNewspaper = TabloidNewspaper;
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (tabloidPaper == statusQuoPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = TabloidNewspaper;
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = StatusQuoNewspaper;
                PlayerHeadline = newspaperHeadlines[1];
            }
        }

        if (tabloidPaper == muckrakerPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = TabloidNewspaper;
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
                PlayerNewspaper = StatusQuoNewspaper;
                PlayerHeadline = newspaperHeadlines[1];
            }
            else{
                PlayerNewspaper = TabloidNewspaper;
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (statusQuoPaper == muckrakerPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
            PlayerNewspaper = StatusQuoNewspaper;
            PlayerHeadline = newspaperHeadlines[1];
           }   
            else{
                PlayerNewspaper = MuckrakerNewspaper;
                PlayerHeadline = newspaperHeadlines[0];
            }    
        }
        //Novak: 0,1,2 Jim: 3,4,5 Julia: 6,7,8 Michael: 9,10,11 Max:, 12,13,14
        //if they are not equal, it'll jump over here
        if (muckrakerPaper > tabloidPaper && muckrakerPaper > statusQuoPaper){
           PlayerNewspaper = MuckrakerNewspaper;
            PlayerHeadline = newspaperHeadlines[0];
        }
        else if (statusQuoPaper > tabloidPaper && statusQuoPaper > muckrakerPaper){
            PlayerNewspaper = StatusQuoNewspaper;
            PlayerHeadline = newspaperHeadlines[1];
        }
        else if (tabloidPaper > muckrakerPaper && tabloidPaper > statusQuoPaper){
            PlayerNewspaper = TabloidNewspaper;
            PlayerHeadline = newspaperHeadlines[2];
        }
        finalNewspaper.text = PlayerNewspaper;
        finalHeadline.text = PlayerHeadline;
        //SAS.ROTDORESAS();
    }
}


