using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CH2Controller : MonoBehaviour
{
    public string PlayerNewspaper, MuckrakerNewspaper, StatusQuoNewspaper, TabloidNewspaper, PlayerHeadline;
    
    //KEEP HERE WHAT IS UNIQUE TO THE ROTDORE STORY
    //IS THIS UNIQUE TO ROTDORE? IF SO, IT GOES HERE
    //IF NOT, IT GOES INTO THE CONTROLLER
    //Audience Feedback Script
    //public AudienceFeedbackScript AFS;

    //All paper holding strings
    string NovakMuckString, NovakSQString, NovakTabloidString;
    string DaniMuckString, DaniSQString, DaniTabloidString;
    string BorisMuckString, BorisSQString, BorisTabloidString;
    string GuyMuckString, GuySQString, GuyTabloidString;
    string CarlaMuckString, CarlaSQString, CarlaTabloidString;
    //NEW STRINGS
    string NovakFinalString, DaniFinalString, GuyFinalString, CarlaFinalString, BorisFinalString;
    string FinalParaOne, FinalParaTwo, FinalParaThree, FinalParaFour;

    //Always Appearing Pieces:
    ///*
    string NovakChoiceOne, NovakChoiceTwo, NovakChoiceThree;
    string DaniChoiceOne, DaniChoiceTwo, DaniChoiceThree;
    string GuyChoiceOne, GuyChoiceTwo, GuyChoiceThree;
    string BorisChoiceOne, BorisChoiceTwo, BorisChoiceThree;
    string CarlaChoiceOne, CarlaChoiceTwo, CarlaChoiceThree;
    //*/


    public Text finalNewspaper, finalHeadline;
    Scene scene;

    void Start(){
        scene = SceneManager.GetActiveScene();
    }

    [HideInInspector]
    public int NovakOutputInt, DaniOutputInt, BorisOutputInt, GuyOutputInt, CarlaOutputInt;
    [HideInInspector]
    public int NovakSQOutputInt, DaniSQOutputInt, BorisSQOutputInt, GuySQOutputInt, CarlaSQOutputInt;
    [HideInInspector]
    public int NovakTabOutputInt, DaniTabOutputInt, BorisTabOutputInt, GuyTabOutputInt, CarlaTabOutputInt;
    //Values
    public int muckrakerPaper, tabloidPaper, statusQuoPaper;
    
    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] newspaperHeadlines, AllNewspaperPieces, AllParaPieces, MuckrakerArticlePieces, SQArticlePieces, TabloidArticlePieces;

    void Update() {
        NewspaperPrint();    
    }

    public void AllPiecesCalculator(){

        //Novak (Ordered like this on purpose!!!!!)
        if (NovakOutputInt == 1){
            NovakChoiceThree = AllNewspaperPieces[0];
        } else if (NovakSQOutputInt == 1){
            NovakChoiceThree = AllNewspaperPieces[1];
        } else if (NovakTabOutputInt == 1){
            NovakChoiceThree = AllNewspaperPieces[2];
        }

        if (NovakOutputInt == 2){
            NovakChoiceOne = AllNewspaperPieces[3];
        } else if (NovakSQOutputInt == 2){
            NovakChoiceOne = AllNewspaperPieces[4];
        } else if (NovakTabOutputInt == 2){
            NovakChoiceOne = AllNewspaperPieces[5];
        }

        if (NovakOutputInt == 3){
            NovakChoiceTwo = AllNewspaperPieces[6];
        } else if (NovakSQOutputInt == 3){
            NovakChoiceTwo = AllNewspaperPieces[7];
        } else if (NovakTabOutputInt == 3){
            NovakChoiceTwo = AllNewspaperPieces[8];
        }

        //Boris
        if (BorisOutputInt == 1){
            BorisChoiceOne = AllNewspaperPieces[9];
        } else if (BorisSQOutputInt == 1){
            BorisChoiceOne = AllNewspaperPieces[10];
        } else if (BorisTabOutputInt == 1){
            BorisChoiceOne = AllNewspaperPieces[11];
        }

        if (BorisOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[12];
        } else if (BorisSQOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[13];
        } else if (BorisTabOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[14];
        }

        if (BorisOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[15];
        } else if (BorisSQOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[16];
        } else if (BorisTabOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[17];
        }

        //Dani
        if (DaniOutputInt == 1){
            DaniChoiceOne = AllNewspaperPieces[18];
        } else if (DaniSQOutputInt == 1){
            DaniChoiceOne = AllNewspaperPieces[19];
        } else if (DaniTabOutputInt == 1){
            DaniChoiceOne = AllNewspaperPieces[20];
        }

        if (DaniOutputInt == 2){
            DaniChoiceTwo = AllNewspaperPieces[21];
        } else if (DaniSQOutputInt == 2){
            DaniChoiceTwo = AllNewspaperPieces[22];
        } else if (DaniTabOutputInt == 2){
            DaniChoiceTwo = AllNewspaperPieces[23];
        }

        if (DaniOutputInt == 3){
            DaniChoiceThree = AllNewspaperPieces[24];
        } else if (DaniSQOutputInt == 3){
            DaniChoiceThree = AllNewspaperPieces[25];
        } else if (DaniTabOutputInt == 3){
            DaniChoiceThree = AllNewspaperPieces[26];
        }

        //Guy
        if (GuyOutputInt == 1){
            GuyChoiceOne = AllNewspaperPieces[27];
        } else if (GuySQOutputInt == 1){
            GuyChoiceOne = AllNewspaperPieces[28];
        } else if (GuyTabOutputInt == 1){
            GuyChoiceOne = AllNewspaperPieces[29];
        }

       if (GuyOutputInt == 2){
            GuyChoiceTwo = AllNewspaperPieces[30];
        } else if (GuySQOutputInt == 2){
            GuyChoiceTwo = AllNewspaperPieces[31];
        } else if (GuyTabOutputInt == 2){
            GuyChoiceTwo = AllNewspaperPieces[32];
        }

        if (GuyOutputInt == 3){
            GuyChoiceThree = AllNewspaperPieces[33];
        } else if (GuySQOutputInt == 3){
            GuyChoiceThree = AllNewspaperPieces[34];
        } else if (GuyTabOutputInt == 3){
            GuyChoiceThree = AllNewspaperPieces[35];
        }

        //Carla
        if (CarlaOutputInt == 1){
            CarlaChoiceOne = AllNewspaperPieces[36];
        } else if (CarlaSQOutputInt == 1){
            CarlaChoiceOne = AllNewspaperPieces[37];
        } else if (CarlaTabOutputInt == 1){
            CarlaChoiceOne = AllNewspaperPieces[38];
        }

        if (CarlaOutputInt == 2){
            CarlaChoiceTwo = AllNewspaperPieces[39];
        } else if (CarlaSQOutputInt == 2){
            CarlaChoiceTwo = AllNewspaperPieces[40];
        } else if (CarlaTabOutputInt == 2){
            CarlaChoiceTwo = AllNewspaperPieces[41];
        }

        if (CarlaOutputInt == 1){
            CarlaChoiceThree = AllNewspaperPieces[42];
        } else if (CarlaSQOutputInt == 1){
            CarlaChoiceThree = AllNewspaperPieces[43];
        } else if (CarlaTabOutputInt == 1){
            CarlaChoiceThree = AllNewspaperPieces[44];
        }
    }


    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt;
        //These are the intros/bits the remain despite the player's choices
        /*NovakParaPiece_One = AllParaPieces[0];
        NovakParaPiece_Two = AllParaPieces[1];
        DaniParaPiece_One = AllParaPieces[2];
        DaniParaPiece_Two = AllParaPieces[3];
        DaniParaPiece_Three = AllParaPieces[4];
        DaniParaPiece_Four = AllParaPieces[5];
        DaniParaPiece_Five = AllParaPieces[6];
        GuyParaPiece_One = AllParaPieces[7];
        GuyParaPiece_Two = AllParaPieces[8];
        CarlaParaPiece_One = AllParaPieces[9];*/
        
        //PAPER PIECING
        AllPiecesCalculator();
        //ParaOne
        FinalParaOne = AllParaPieces[0] + " " + BorisChoiceThree + " " + AllParaPieces[1] + " " + GuyChoiceOne + " " + AllParaPieces[2] + " " + NovakChoiceThree;
        FinalParaTwo = AllParaPieces[3] + " " + GuyChoiceThree + " " + GuyChoiceTwo + " " + AllNewspaperPieces[4] + " " + NovakChoiceTwo + " " + DaniChoiceOne + " " + NovakChoiceOne;
        FinalParaThree = AllParaPieces[5] + " " + DaniChoiceThree + " " + " " + DaniChoiceTwo;
        FinalParaFour = AllParaPieces[6] + " " + CarlaChoiceOne + " " + AllParaPieces[7] + " " + CarlaChoiceThree + " " + AllParaPieces[8] + " " + CarlaChoiceTwo + " " + AllParaPieces[9];

        MuckrakerNewspaper = FinalParaOne + "\n" + FinalParaTwo + "\n" + FinalParaThree + "\n" + FinalParaFour;
        StatusQuoNewspaper = FinalParaOne + "\n" + FinalParaTwo + "\n" + FinalParaThree + "\n" + FinalParaFour;
        TabloidNewspaper = FinalParaOne + "\n" + FinalParaTwo + "\n" + FinalParaThree + "\n" + FinalParaFour;
    
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
        //Novak: 0,1,2 Dani: 3,4,5 Boris: 6,7,8 Carla: 9,10,11 Guy:, 12,13,14
        //if they are not equal, it'll mp over here
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

