using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ROTDOREController : MonoBehaviour
{
    public string PlayerNewspaper, MuckrakerNewspaper, StatusQuoNewspaper, TabloidNewspaper, PlayerHeadline;
    
    //KEEP HERE WHAT IS UNIQUE TO THE ROTDORE STORY
    //IS THIS UNIQUE TO ROTDORE? IF SO, IT GOES HERE
    //IF NOT, IT GOES INTO THE CONTROLLER
    //Audience Feedback Script
    //public AudienceFeedbackScript AFS;

    //All paper holding strings
    string NovakMuckString, NovakSQString, NovakTabloidString;
    string JimMuckString, JimSQString, JimTabloidString;
    string JuliaMuckString, JuliaSQString, JuliaTabloidString;
    string MaxMuckString, MaxSQString, MaxTabloidString;
    string MichaelMuckString, MichaelSQString, MichaelTabloidString;
    //NEW STRINGS
    string NovakFinalString, JuJimFinalString, MaxFinalString, MichaelFinalString;

    //Always Appearing Pieces:
    string novakParaPiece_One, novakParaPiece_Two, novakChoiceOne, novakChoiceTwo, novakChoiceThree;
    string jimChoiceOne, jimChoiceTwo, jimChoiceThree;
    string jujimParaPiece_One, jujimParaPiece_Two, jujimParaPiece_Three, jujimParaPiece_Four, jujimParaPiece_Five, juliaChoiceOne, juliaChoiceTwo, juliaChoiceThree;
    string mikeParaPiece_One, mikeChoiceOne, mikeChoiceTwo, mikeChoiceThree;
    string maxParaPiece_One, maxParaPiece_Two, maxChoiceOne, maxChoiceTwo, maxChoiceThree;

    public Text finalNewspaper, finalHeadline;

    [HideInInspector]
    public int NovakOutputInt, JimOutputInt, JuliaOutputInt, MaxOutputInt, MikeOutputInt;
    [HideInInspector]
    public int NovakSQOutputInt, JimSQOutputInt, JuliaSQOutputInt, MaxSQOutputInt, MikeSQOutputInt;
    [HideInInspector]
    public int NovakTabOutputInt, JimTabOutputInt, JuliaTabOutputInt, MaxTabOutputInt, MikeTabOutputInt;
    //Values
    public int muckrakerPaper, tabloidPaper, statusQuoPaper;
    
    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] newspaperHeadlines, AllNewspaperPieces, AllParaPieces, MuckrakerArticlePieces, SQArticlePieces, TabloidArticlePieces;

    void Update() {
        NewspaperPrint();    
    }

    public void MuckPieceCalculator(){
        //Muckraker
        /*if (NovakOutputInt == 1){
            NovakMuckString = MuckrakerArticlePieces[0];
        } else if (NovakOutputInt == 2){
            NovakMuckString = MuckrakerArticlePieces[1];
        } else if (NovakOutputInt == 3){
            NovakMuckString = MuckrakerArticlePieces[2];
        }*/

         if (JimOutputInt == 1){
            JimMuckString = MuckrakerArticlePieces[3];
        } else if (JimOutputInt == 2){
            JimMuckString = MuckrakerArticlePieces[4];
        } else if (JimOutputInt == 3){
            JimMuckString = MuckrakerArticlePieces[5];
        }

        if (JuliaOutputInt == 1){
            JuliaMuckString = MuckrakerArticlePieces[6];
        } else if (JuliaOutputInt == 2){
            JuliaMuckString = MuckrakerArticlePieces[7];
        } else if (JimOutputInt == 3){
            JuliaMuckString = MuckrakerArticlePieces[8];
        }

        if (MikeOutputInt == 1){
            MichaelMuckString = MuckrakerArticlePieces[12];
        } else if (MikeOutputInt == 2){
            MichaelMuckString = MuckrakerArticlePieces[13];
        } else if (MikeOutputInt == 3){
            MichaelMuckString = MuckrakerArticlePieces[14];
        }

        if (MaxOutputInt == 1){
            MaxMuckString = MuckrakerArticlePieces[9];
        } else if (MaxOutputInt == 2){
            MaxMuckString = MuckrakerArticlePieces[10];
        } else if (MikeOutputInt == 3){
            MaxMuckString = MuckrakerArticlePieces[11];
        }
        
    }

    public void SQPieceCalculator(){
        //SQ
        /*
        if (NovakSQOutputInt == 1){
            NovakSQString = SQArticlePieces[0];

        } else if (NovakSQOutputInt == 2){
            NovakSQString = SQArticlePieces[1];
        } else if (NovakSQOutputInt == 3){
            NovakSQString = SQArticlePieces[2];
        }
        */
         if (JimSQOutputInt == 1){
            JimSQString = SQArticlePieces[3];
        } else if (JimSQOutputInt == 2){
            JimSQString = SQArticlePieces[4];
        } else if (JimSQOutputInt == 3){
            JimSQString = SQArticlePieces[5];
        }

       if (JuliaSQOutputInt == 1){
            JuliaSQString = SQArticlePieces[6];
        } else if (JuliaSQOutputInt == 2){
            JuliaSQString = SQArticlePieces[7];
        } else if (JuliaSQOutputInt == 3){
            JuliaSQString = SQArticlePieces[8];
        }

        //SQ
        if (MikeSQOutputInt  == 1){
            MichaelSQString = SQArticlePieces[12];
        } else if (MikeSQOutputInt == 2){
            MichaelSQString = SQArticlePieces[13];
        } else if (MikeSQOutputInt == 3){
            MichaelSQString = SQArticlePieces[14];
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

    public void TabPieceCalculator(){
        //Tab
        /*
        if (NovakTabOutputInt == 1){
            NovakTabloidString = TabloidArticlePieces[0];
        } else if (NovakTabOutputInt == 2){
            NovakTabloidString = TabloidArticlePieces[1];
        } else if (NovakTabOutputInt == 3){
            NovakTabloidString = TabloidArticlePieces[2];
        }*/

        if (JimTabOutputInt == 1){
            JimTabloidString = TabloidArticlePieces[3];
        } else if (JimTabOutputInt == 2){
            JimTabloidString = TabloidArticlePieces[4];
        } else if (JimTabOutputInt == 3){
            JimTabloidString = TabloidArticlePieces[5];
        }

        if (JuliaTabOutputInt  == 1){
            JuliaTabloidString = TabloidArticlePieces[6];
        } else if (JuliaTabOutputInt == 2){
            JuliaTabloidString = TabloidArticlePieces[7];
        } else if (JuliaTabOutputInt == 3){
            JuliaTabloidString = TabloidArticlePieces[8];
        }

        //Tabloid
        if (MikeTabOutputInt  == 1){
            MichaelTabloidString = TabloidArticlePieces[12];
        } else if (MikeTabOutputInt == 2){
            MichaelTabloidString = TabloidArticlePieces[13];
        } else if (MikeTabOutputInt == 3){
            MichaelTabloidString = TabloidArticlePieces[14];
        }

        if (MaxTabOutputInt == 1){
            MaxTabloidString = TabloidArticlePieces[9];
        } else if (MaxTabOutputInt == 2){
            MaxTabloidString = TabloidArticlePieces[10];
        } else if (MaxTabOutputInt == 3){
            MaxTabloidString = TabloidArticlePieces[11];
        }

    }

    public void AllPiecesCalculator(){

        //Novak
        if (NovakOutputInt == 1){
            novakChoiceThree = AllNewspaperPieces[0];
        } else if (NovakSQOutputInt == 1){
            novakChoiceThree = AllNewspaperPieces[1];
        } else if (NovakTabOutputInt == 1){
            novakChoiceThree = AllNewspaperPieces[2];
        }

        if (NovakOutputInt == 2){
            novakChoiceOne = AllNewspaperPieces[3];
        } else if (NovakSQOutputInt == 2){
            novakChoiceOne = AllNewspaperPieces[4];
        } else if (NovakTabOutputInt == 2){
            novakChoiceOne = AllNewspaperPieces[5];
        }

        if (NovakOutputInt == 3){
            novakChoiceTwo = AllNewspaperPieces[6];
        } else if (NovakSQOutputInt == 3){
            novakChoiceTwo = AllNewspaperPieces[7];
        } else if (NovakTabOutputInt == 3){
            novakChoiceTwo = AllNewspaperPieces[8];
        }

        //Julia
        if (JuliaOutputInt == 1){
            juliaChoiceOne = AllNewspaperPieces[9];
        } else if (JuliaSQOutputInt == 1){
            juliaChoiceOne = AllNewspaperPieces[10];
        } else if (JuliaTabOutputInt == 1){
            juliaChoiceOne = AllNewspaperPieces[11];
        }

        if (JuliaOutputInt == 2){
            juliaChoiceTwo = AllNewspaperPieces[12];
        } else if (JuliaSQOutputInt == 2){
            juliaChoiceTwo = AllNewspaperPieces[13];
        } else if (JuliaTabOutputInt == 2){
            juliaChoiceTwo = AllNewspaperPieces[14];
        }

        if (JuliaOutputInt == 3){
            juliaChoiceThree = AllNewspaperPieces[15];
        } else if (JuliaSQOutputInt == 3){
            juliaChoiceThree = AllNewspaperPieces[16];
        } else if (JuliaTabOutputInt == 3){
            juliaChoiceThree = AllNewspaperPieces[17];
        }

        //Jim
        if (JimOutputInt == 1){
            jimChoiceOne = AllNewspaperPieces[18];
        } else if (JimSQOutputInt == 1){
            jimChoiceOne = AllNewspaperPieces[19];
        } else if (JimTabOutputInt == 1){
            jimChoiceOne = AllNewspaperPieces[20];
        }

        if (JimOutputInt == 2){
            jimChoiceTwo = AllNewspaperPieces[21];
        } else if (JimSQOutputInt == 2){
            jimChoiceTwo = AllNewspaperPieces[22];
        } else if (JimTabOutputInt == 2){
            jimChoiceTwo = AllNewspaperPieces[23];
        }

        if (JimOutputInt == 3){
            jimChoiceThree = AllNewspaperPieces[24];
        } else if (JimSQOutputInt == 3){
            jimChoiceThree = AllNewspaperPieces[25];
        } else if (JimTabOutputInt == 3){
            jimChoiceThree = AllNewspaperPieces[26];
        }

        //Max
        if (MaxOutputInt == 1){
            maxChoiceOne = AllNewspaperPieces[27];
        } else if (MaxSQOutputInt == 1){
            maxChoiceOne = AllNewspaperPieces[28];
        } else if (MaxTabOutputInt == 1){
            maxChoiceOne = AllNewspaperPieces[29];
        }

       if (MaxOutputInt == 2){
            maxChoiceTwo = AllNewspaperPieces[30];
        } else if (MaxSQOutputInt == 2){
            maxChoiceTwo = AllNewspaperPieces[31];
        } else if (MaxTabOutputInt == 2){
            maxChoiceTwo = AllNewspaperPieces[32];
        }

        if (MaxOutputInt == 3){
            maxChoiceThree = AllNewspaperPieces[33];
        } else if (MaxSQOutputInt == 3){
            maxChoiceThree = AllNewspaperPieces[34];
        } else if (MaxTabOutputInt == 3){
            maxChoiceThree = AllNewspaperPieces[35];
        }

        //Mike
        if (MikeOutputInt == 1){
            mikeChoiceOne = AllNewspaperPieces[36];
        } else if (MikeSQOutputInt == 1){
            mikeChoiceOne = AllNewspaperPieces[37];
        } else if (MikeTabOutputInt == 1){
            mikeChoiceOne = AllNewspaperPieces[38];
        }

        if (MikeOutputInt == 2){
            mikeChoiceTwo = AllNewspaperPieces[39];
        } else if (MikeSQOutputInt == 2){
            mikeChoiceTwo = AllNewspaperPieces[40];
        } else if (MikeTabOutputInt == 2){
            mikeChoiceTwo = AllNewspaperPieces[41];
        }

        if (MikeOutputInt == 1){
            mikeChoiceThree = AllNewspaperPieces[42];
        } else if (MikeSQOutputInt == 1){
            mikeChoiceThree = AllNewspaperPieces[43];
        } else if (MikeTabOutputInt == 1){
            mikeChoiceThree = AllNewspaperPieces[44];
        }
    }


    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt;
        novakParaPiece_One = AllParaPieces[0];
        novakParaPiece_Two = AllParaPieces[1];
        jujimParaPiece_One = AllParaPieces[2];
        jujimParaPiece_Two = AllParaPieces[3];
        jujimParaPiece_Three = AllParaPieces[4];
        jujimParaPiece_Four = AllParaPieces[5];
        jujimParaPiece_Five = AllParaPieces[6];
        maxParaPiece_One = AllParaPieces[7];
        maxParaPiece_Two = AllParaPieces[8];
        mikeParaPiece_One = AllParaPieces[9];
        
        //PAPER PIECING
        //MuckPieceCalculator();
        //SQPieceCalculator();
        //TabPieceCalculator();
        AllPiecesCalculator();



        /*
        //Old code
        MuckrakerNewspaper = NovakMuckString + "\n" + JuliaMuckString + "\n" + JimMuckString + "\n" + MaxMuckString + "\n" + MichaelMuckString;
        StatusQuoNewspaper = NovakSQString + "\n" + JuliaSQString + "\n" + JimSQString + "\n" + MaxSQString + "\n" + MichaelSQString;
        TabloidNewspaper = NovakTabloidString + "\n" + JuliaTabloidString + "\n" + JimTabloidString + "\n" + MaxTabloidString + "\n" + MichaelTabloidString;
        
        MuckrakerNewspaper = NovakFinalString + "\n" + JuliaMuckString + "\n" + JimMuckString + "\n" + MaxMuckString + "\n" + MichaelMuckString;
        StatusQuoNewspaper = NovakFinalString + "\n" + JuliaSQString + "\n" + JimSQString + "\n" + MaxSQString + "\n" + MichaelSQString;
        TabloidNewspaper = NovakFinalString + "\n" + JuliaTabloidString + "\n" + JimTabloidString + "\n" + MaxTabloidString + "\n" + MichaelTabloidString;

        */

        //New WIP Code
        NovakFinalString = novakParaPiece_One + " " + novakChoiceThree + " " + novakParaPiece_Two + " " + novakChoiceOne + " " + novakChoiceTwo;
        JuJimFinalString = jujimParaPiece_One + " " + juliaChoiceOne + " " + jujimParaPiece_Two + " " + juliaChoiceTwo + " " + juliaChoiceThree + " " + jujimParaPiece_Three + " " + jimChoiceOne + " " + jimChoiceTwo + " " + jujimParaPiece_Four + " " + jimChoiceThree + " " + jujimParaPiece_Five;
        MaxFinalString = maxParaPiece_One  + " " + maxChoiceOne  + " " + maxParaPiece_Two  + " " +  maxChoiceTwo  + " " + maxChoiceThree;
        MichaelFinalString = mikeChoiceOne  + " " + mikeChoiceTwo  + " " + mikeChoiceThree + " " + mikeParaPiece_One;
        //Debug.Log(NovakFinalString);
        
        MuckrakerNewspaper = NovakFinalString + "\n" + JuJimFinalString + "\n" + MaxFinalString + "\n" + MichaelFinalString;
        StatusQuoNewspaper = NovakFinalString + "\n" + JuJimFinalString + "\n" + MaxFinalString + "\n" + MichaelFinalString;
        TabloidNewspaper = NovakFinalString + "\n" + JuJimFinalString + "\n" + MaxFinalString + "\n" + MichaelFinalString;


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
    }
}
