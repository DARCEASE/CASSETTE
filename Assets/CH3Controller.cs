using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CH3Controller : MonoBehaviour
{
    public string PlayerNewspaper, ANewspaper, CNewspaper, BNewspaper, PlayerHeadline;
    
    //KEEP HERE WHAT IS UNIQUE TO THE CH3
    //IS THIS UNIQUE TO CH3? IF SO, IT GOES HERE
    //IF NOT, IT GOES INTO THE CONTROLLER
    //Audience Feedback Script
    //public AudienceFeedbackScript AFS;

    //All paper holding strings
    string BorisMuckString, BorisSQString, BorisBString;
    string FranzMuckString, FranzSQString, FranzBString;
    string GloriaMuckString, GloriaSQString, GloriaBString;
    string RuthMuckString, RuthSQString, RuthBString;
    string DunnMuckString, DunnSQString, DunnBString;
    //NEW STRINGS
    string FranzFinalString, GloriaFinalString, RuthFinalString, DunnFinalString, BorisFinalString;
    string FinalParaOne, FinalParaTwo, FinalParaThree, FinalParaFour;

    [HideInInspector]
    public int FranzOutputInt, BorisOutputInt, GloriaOutputInt, RuthOutputInt, DunnOutputInt;
    [HideInInspector]
    public int FranzSQOutputInt, BorisSQOutputInt, GloriaSQOutputInt, RuthSQOutputInt, DunnSQOutputInt;
    [HideInInspector]
    public int FranzTabOutputInt, BorisTabOutputInt, GloriaTabOutputInt, RuthTabOutputInt, DunnTabOutputInt;

    
    //Always Appearing Pieces:
    ///*
    string FranzChoiceOne, FranzChoiceTwo, FranzChoiceThree;
    string RuthChoiceOne, RuthChoiceTwo, RuthChoiceThree;
    string GloriaChoiceOne, GloriaChoiceTwo, GloriaChoiceThree;
    string BorisChoiceOne, BorisChoiceTwo, BorisChoiceThree;
    string DunnChoiceOne, DunnChoiceTwo, DunnChoiceThree;
    //*/

    public Text finalNewspaper, finalHeadline;
    Scene scene;

    void Start(){
        scene = SceneManager.GetActiveScene();
    }
    //Values
    public int APaper, BPaper, CPaper;
    
    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] newspaperHeadlines, AllNewspaperPieces, AllParaPieces;

    void Update() {
        NewspaperPrint();
    }

    public void AllPiecesCalculator(){

        //Franz (Ordered like this on purpose!!!!!)
        if (FranzOutputInt == 1){
            FranzChoiceThree = AllNewspaperPieces[21];
        } else if (FranzSQOutputInt == 1){
            FranzChoiceThree = AllNewspaperPieces[22];
        } else if (FranzTabOutputInt == 1){
            FranzChoiceThree = AllNewspaperPieces[23];
        }

        if (FranzOutputInt == 2){
            FranzChoiceOne = AllNewspaperPieces[0];
        } else if (FranzSQOutputInt == 2){
            FranzChoiceOne = AllNewspaperPieces[1];
        } else if (FranzTabOutputInt == 2){
            FranzChoiceOne = AllNewspaperPieces[2];
        }

        if (FranzOutputInt == 3){
            FranzChoiceTwo = AllNewspaperPieces[3];
        } else if (FranzSQOutputInt == 3){
            FranzChoiceTwo = AllNewspaperPieces[4];
        } else if (FranzTabOutputInt == 3){
            FranzChoiceTwo = AllNewspaperPieces[5];
        }

        //Boris
        if (BorisOutputInt == 1){
            BorisChoiceOne = AllNewspaperPieces[21];
        } else if (BorisSQOutputInt == 1){
            BorisChoiceOne = AllNewspaperPieces[22];
        } else if (BorisTabOutputInt == 1){
            BorisChoiceOne = AllNewspaperPieces[23];
        }

        if (BorisOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[24];
        } else if (BorisSQOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[25];
        } else if (BorisTabOutputInt == 2){
            BorisChoiceTwo = AllNewspaperPieces[26];
        }

        if (BorisOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[42];
        } else if (BorisSQOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[41];
        } else if (BorisTabOutputInt == 3){
            BorisChoiceThree = AllNewspaperPieces[40];
        }

        //Ruth
        if (RuthOutputInt == 1){
            RuthChoiceOne = AllNewspaperPieces[6];
        } else if (RuthSQOutputInt == 1){
            RuthChoiceOne = AllNewspaperPieces[7];
        } else if (RuthTabOutputInt == 1){
            RuthChoiceOne = AllNewspaperPieces[8];
        }

        if (RuthOutputInt == 2){
            RuthChoiceTwo = AllNewspaperPieces[12];
        } else if (RuthSQOutputInt == 2){
            RuthChoiceTwo = AllNewspaperPieces[13];
        } else if (RuthTabOutputInt == 2){
            RuthChoiceTwo = AllNewspaperPieces[14];
        }

        if (RuthOutputInt == 3){
            RuthChoiceThree = AllNewspaperPieces[9];
        } else if (RuthSQOutputInt == 3){
            RuthChoiceThree = AllNewspaperPieces[10];
        } else if (RuthTabOutputInt == 3){
            RuthChoiceThree = AllNewspaperPieces[11];
        }

        //Gloria
        if (GloriaOutputInt == 1){
            GloriaChoiceOne = AllNewspaperPieces[15];
        } else if (GloriaSQOutputInt == 1){
            GloriaChoiceOne = AllNewspaperPieces[16];
        } else if (GloriaTabOutputInt == 1){
            GloriaChoiceOne = AllNewspaperPieces[17];
        }

       if (GloriaOutputInt == 2){
            GloriaChoiceTwo = AllNewspaperPieces[18];
        } else if (GloriaSQOutputInt == 2){
            GloriaChoiceTwo = AllNewspaperPieces[19];
        } else if (GloriaTabOutputInt == 2){
            GloriaChoiceTwo = AllNewspaperPieces[20];
        }

        if (GloriaOutputInt == 3){
            GloriaChoiceThree = AllNewspaperPieces[36];
        } else if (GloriaSQOutputInt == 3){
            GloriaChoiceThree = AllNewspaperPieces[37];
        } else if (GloriaTabOutputInt == 3){
            GloriaChoiceThree = AllNewspaperPieces[38];
        }

        //Dunn
        if (DunnOutputInt == 1){
            DunnChoiceOne = AllNewspaperPieces[30];
        } else if (DunnSQOutputInt == 1){
            DunnChoiceOne = AllNewspaperPieces[31];
        } else if (DunnTabOutputInt == 1){
            DunnChoiceOne = AllNewspaperPieces[32];
        }

        if (DunnOutputInt == 2){
            DunnChoiceTwo = AllNewspaperPieces[27];
        } else if (DunnSQOutputInt == 2){
            DunnChoiceTwo = AllNewspaperPieces[28];
        } else if (DunnTabOutputInt == 2){
            DunnChoiceTwo = AllNewspaperPieces[29];
        }

        if (DunnOutputInt == 3){
            DunnChoiceThree = AllNewspaperPieces[33];
        } else if (DunnSQOutputInt == 1){
            DunnChoiceThree = AllNewspaperPieces[34];
        } else if (DunnTabOutputInt == 1){
            DunnChoiceThree = AllNewspaperPieces[35];
        }
    }

    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt;
        //These are the intros/bits the remain despite the player's choices
        //PAPER PIECING
        AllPiecesCalculator();
        //ParaOne
        FinalParaOne = AllParaPieces[0] + " " + FranzChoiceOne + " " + AllParaPieces[1] + " " + FranzChoiceTwo;
        FinalParaTwo = AllParaPieces[2] + " " + RuthChoiceOne + " " + AllParaPieces[3] + " " + RuthChoiceThree+ " " + AllParaPieces[4] + " " + RuthChoiceTwo + " " + AllParaPieces[5];
        FinalParaThree = AllParaPieces[6] + " " + GloriaChoiceOne + " " + AllParaPieces[7] + " " + GloriaChoiceTwo + " " + AllParaPieces[8] + " " + BorisChoiceOne + " " + AllParaPieces[9] + " " + BorisChoiceTwo + " " + AllParaPieces[10] + DunnChoiceTwo + " " + AllParaPieces[11] + " " + DunnChoiceOne + " " + DunnChoiceThree;
        FinalParaFour = AllParaPieces[12] + " " + GloriaChoiceThree + " " + AllParaPieces[13] + " " + BorisChoiceThree + " " + AllParaPieces[14] + " " + FranzChoiceThree + " " + AllParaPieces[15];

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
        //Franz: 0,1,2 Ruth: 3,4,5 Boris: 6,7,8 Dunn: 9,10,11 Gloria:, 12,13,14
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
    }
}

