using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CH2Controller : MonoBehaviour
{
    public string PlayerNewspaper, ANewspaper, CNewspaper, BNewspaper, PlayerHeadline;
    
    //KEEP HERE WHAT IS UNIQUE TO THE CH2
    //IS THIS UNIQUE TO CH2? IF SO, IT GOES HERE
    //IF NOT, IT GOES INTO THE CONTROLLER
    //Audience Feedback Script
    //public AudienceFeedbackScript AFS;

    //All paper holding strings
    string NovakMuckString, NovakSQString, NovakBString;
    string DaniMuckString, DaniSQString, DaniBString;
    string BorisMuckString, BorisSQString, BorisBString;
    string GuyMuckString, GuySQString, GuyBString;
    string CarlaMuckString, CarlaSQString, CarlaBString;
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
    public int NovakOutputInt, DaniOutputInt, BorisOutputInt, GuyOutputInt, CarlaOutputInt; //A
    [HideInInspector]
    public int NovakSQOutputInt, DaniSQOutputInt, BorisSQOutputInt, GuySQOutputInt, CarlaSQOutputInt; //B
    [HideInInspector]
    public int NovakTabOutputInt, DaniTabOutputInt, BorisTabOutputInt, GuyTabOutputInt, CarlaTabOutputInt; //C
    //Values
    public int APaper, BPaper, CPaper;
    
    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] newspaperHeadlines, AllNewspaperPieces, AllParaPieces, AArticlePieces, SQArticlePieces, BArticlePieces;

    void Update() {
        NewspaperPrint();    
    }

    public void AllPiecesCalculator(){

        //Novak (Ordered like this on purpose!!!!!)
        if (NovakOutputInt == 1){
            NovakChoiceThree = AllNewspaperPieces[21];
        } else if (NovakSQOutputInt == 1){
            NovakChoiceThree = AllNewspaperPieces[22];
        } else if (NovakTabOutputInt == 1){
            NovakChoiceThree = AllNewspaperPieces[23];
        }

        if (NovakOutputInt == 2){
            NovakChoiceOne = AllNewspaperPieces[15];
        } else if (NovakSQOutputInt == 2){
            NovakChoiceOne = AllNewspaperPieces[16];
        } else if (NovakTabOutputInt == 2){
            NovakChoiceOne = AllNewspaperPieces[17];
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
            BorisChoiceOne = AllNewspaperPieces[39];
        } else if (BorisSQOutputInt == 1){
            BorisChoiceOne = AllNewspaperPieces[40];
        } else if (BorisTabOutputInt == 1){
            BorisChoiceOne = AllNewspaperPieces[41];
        }

        if (BorisOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[42];
        } else if (BorisSQOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[43];
        } else if (BorisTabOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[44];
        }

        if (BorisOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[0];
        } else if (BorisSQOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[1];
        } else if (BorisTabOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[2];
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
            DaniChoiceTwo = AllNewspaperPieces[27];
        } else if (DaniSQOutputInt == 2){
            DaniChoiceTwo = AllNewspaperPieces[28];
        } else if (DaniTabOutputInt == 2){
            DaniChoiceTwo = AllNewspaperPieces[29];
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
            GuyChoiceOne = AllNewspaperPieces[3];
        } else if (GuySQOutputInt == 1){
            GuyChoiceOne = AllNewspaperPieces[4];
        } else if (GuyTabOutputInt == 1){
            GuyChoiceOne = AllNewspaperPieces[5];
        }

       if (GuyOutputInt == 2){
            GuyChoiceTwo = AllNewspaperPieces[12];
        } else if (GuySQOutputInt == 2){
            GuyChoiceTwo = AllNewspaperPieces[13];
        } else if (GuyTabOutputInt == 2){
            GuyChoiceTwo = AllNewspaperPieces[14];
        }

        if (GuyOutputInt == 3){
            GuyChoiceThree = AllNewspaperPieces[9];
        } else if (GuySQOutputInt == 3){
            GuyChoiceThree = AllNewspaperPieces[10];
        } else if (GuyTabOutputInt == 3){
            GuyChoiceThree = AllNewspaperPieces[11];
        }

        //Carla
        if (CarlaOutputInt == 1){
            CarlaChoiceOne = AllNewspaperPieces[30];
        } else if (CarlaSQOutputInt == 1){
            CarlaChoiceOne = AllNewspaperPieces[31];
        } else if (CarlaTabOutputInt == 1){
            CarlaChoiceOne = AllNewspaperPieces[32];
        }

        if (CarlaOutputInt == 2){
            CarlaChoiceTwo = AllNewspaperPieces[36];
        } else if (CarlaSQOutputInt == 2){
            CarlaChoiceTwo = AllNewspaperPieces[37];
        } else if (CarlaTabOutputInt == 2){
            CarlaChoiceTwo = AllNewspaperPieces[38];
        }

        if (CarlaOutputInt == 1){
            CarlaChoiceThree = AllNewspaperPieces[33];
        } else if (CarlaSQOutputInt == 1){
            CarlaChoiceThree = AllNewspaperPieces[34];
        } else if (CarlaTabOutputInt == 1){
            CarlaChoiceThree = AllNewspaperPieces[35];
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

        ANewspaper = FinalParaOne + "\n" + FinalParaTwo + "\n" + FinalParaThree + "\n" + FinalParaFour;
        CNewspaper = FinalParaOne + "\n" + FinalParaTwo + "\n" + FinalParaThree + "\n" + FinalParaFour;
        BNewspaper = FinalParaOne + "\n" + FinalParaTwo + "\n" + FinalParaThree + "\n" + FinalParaFour;
    
        //Value Check
        if (APaper == CPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = ANewspaper;
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = CNewspaper;
                PlayerHeadline = newspaperHeadlines[1];
            }   
        }

        if (APaper == BPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = ANewspaper;
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = BNewspaper;
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (BPaper == CPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = BNewspaper;
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = CNewspaper;
                PlayerHeadline = newspaperHeadlines[1];
            }
        }

        if (BPaper == APaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = BNewspaper;
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = ANewspaper;
                PlayerHeadline = newspaperHeadlines[0];
            }
        }

        if (CPaper == BPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = CNewspaper;
                PlayerHeadline = newspaperHeadlines[1];
            }
            else{
                PlayerNewspaper = BNewspaper;
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (CPaper == APaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
            PlayerNewspaper = CNewspaper;
            PlayerHeadline = newspaperHeadlines[1];
           }   
            else{
                PlayerNewspaper = ANewspaper;
                PlayerHeadline = newspaperHeadlines[0];
            }    
        }
        //Novak: 0,1,2 Dani: 3,4,5 Boris: 6,7,8 Carla: 9,10,11 Guy:, 12,13,14
        //if they are not equal, it'll mp over here
        if (APaper > BPaper && APaper > CPaper){
           PlayerNewspaper = ANewspaper;
            PlayerHeadline = newspaperHeadlines[0];
        }
        else if (CPaper > BPaper && CPaper > APaper){
            PlayerNewspaper = CNewspaper;
            PlayerHeadline = newspaperHeadlines[1];
        }
        else if (BPaper > APaper && BPaper > CPaper){
            PlayerNewspaper = BNewspaper;
            PlayerHeadline = newspaperHeadlines[2];
        }

        finalNewspaper.text = PlayerNewspaper;
        finalHeadline.text = PlayerHeadline;
    }
}

