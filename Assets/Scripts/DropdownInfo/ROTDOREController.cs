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
    [SerializeField] string[] newspaperHeadlines, MuckrakerArticlePieces, SQArticlePieces, TabloidArticlePieces;

    void Update() {
        NewspaperPrint();    
    }

    public void MuckPieceCalculator(){
        //Muckraker
        if (NovakOutputInt == 1){
            NovakMuckString = MuckrakerArticlePieces[0];
        } else if (NovakOutputInt == 2){
            NovakMuckString = MuckrakerArticlePieces[1];
        } else if (NovakOutputInt == 3){
            NovakMuckString = MuckrakerArticlePieces[2];
        }

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
        if (NovakSQOutputInt == 1){
            NovakSQString = SQArticlePieces[0];

        } else if (NovakSQOutputInt == 2){
            NovakSQString = SQArticlePieces[1];
        } else if (NovakSQOutputInt == 3){
            NovakSQString = SQArticlePieces[2];
        }

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
        if (NovakTabOutputInt == 1){
            NovakTabloidString = TabloidArticlePieces[0];
        } else if (NovakTabOutputInt == 2){
            NovakTabloidString = TabloidArticlePieces[1];
        } else if (NovakTabOutputInt == 3){
            NovakTabloidString = TabloidArticlePieces[2];
        }

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


    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt;
        //PAPER PIECING
        MuckPieceCalculator();
        SQPieceCalculator();
        TabPieceCalculator();

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

        Debug.Log(PlayerNewspaper);
    }
}
