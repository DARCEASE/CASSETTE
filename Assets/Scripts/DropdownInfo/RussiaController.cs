using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RussiaController : MonoBehaviour
{
    public string PlayerNewspaper, PlayerHeadline, AngryNewspaper, CompassionateNewspaper, FearfulNewspaper;
    public Text finalNewspaper, finalHeadline;
    //Audience Feedback Script
    public AudienceFeedbackScript AFS;

    //All paper holding strings
    // APaper = Angry, BPaper = Fearful, CPaper = Compassionte
    string BorisAPaperString, BorisBPaperString, BorisCPaperString;
    string GuyAPaperString, GuyBPaperString, GuyCPaperString;
    string VitoAPaperString, VitoBPaperString, VitoCPaperString;
    string BrightonAPaperString, BrightonBPaperString, BrightonCPaperString;
    string FranzAPaperString, FranzBPaperString, FranzCPaperString;
    
    [SerializeField] public int BorisAOutputInt, GuyAOutputInt, VitoAOutputInt, BrightonAOutputInt, FranzAOutputInt;//angry
    [SerializeField] public int BorisBOutputInt, GuyBOutputInt, VitoBOutputInt, BrightonBOutputInt, FranzBOutputInt;//fearful
    [SerializeField] public int BorisCOutputInt, GuyCOutputInt, VitoCOutputInt, BrightonCOutputInt, FranzCOutputInt;//compassionate

    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.
    [SerializeField] string[] APaperArticlePieces, BPaperArticlePieces, CPaperArticlePieces;// angry, fearful, Compassionate article pieces 
    [SerializeField] string[] newspaperHeadlines;

    [SerializeField] public int AngryPaper,FearfulPaper, CompassionatePaper;
    
    // Update is called once per frame
    void Update()
    {
        NewspaperPrint();    
    }
    //Order: ANgry, Fearful Comp
    public void AngPieceCalculator(){

        //If A (Angry)
        if (BorisAOutputInt == 1){
            BorisAPaperString = APaperArticlePieces[4];

        } else if (BorisAOutputInt == 2){
            BorisAPaperString = APaperArticlePieces[5];
        } else if (BorisAOutputInt == 3){
            BorisAPaperString = APaperArticlePieces[6];
        }

        if (VitoAOutputInt == 1){
            VitoAPaperString = APaperArticlePieces[9];

        } else if (VitoAOutputInt == 2){
            VitoAPaperString = APaperArticlePieces[10];
        } else if (VitoAOutputInt == 3){
            VitoAPaperString = APaperArticlePieces[11];
        }

        if (GuyAOutputInt == 1){
            GuyAPaperString = APaperArticlePieces[6];
        } else if (VitoBOutputInt == 2){
            GuyAPaperString = APaperArticlePieces[7];
        } else if (VitoBOutputInt == 3){
            GuyAPaperString = APaperArticlePieces[8];
        }

        if (FranzAOutputInt == 1){
            FranzAPaperString = APaperArticlePieces[12];
        } else if (FranzAOutputInt == 2){
            FranzAPaperString = APaperArticlePieces[13];
        } else if (FranzAOutputInt == 3){
            FranzAPaperString = APaperArticlePieces[14];
        }

        if (BrightonAOutputInt == 1){
            BrightonAPaperString = APaperArticlePieces[0];
        } else if (BrightonAOutputInt == 2){
            BrightonAPaperString = APaperArticlePieces[1];
        } else if (BrightonAOutputInt == 3){
            BrightonAPaperString = APaperArticlePieces[2];
        }
    }

    public void FearPieceCalculator(){
        
              //If B (FEarful)
        if (BorisBOutputInt == 1){
            BorisBPaperString = BPaperArticlePieces[4];

        } else if (BorisBOutputInt == 2){
            BorisBPaperString = BPaperArticlePieces[5];
        } else if (BorisBOutputInt == 3){
            BorisBPaperString = BPaperArticlePieces[6];
        }

        if (VitoBOutputInt == 1){
            VitoBPaperString = BPaperArticlePieces[9];
        } else if (VitoBOutputInt == 2){
            VitoBPaperString = BPaperArticlePieces[10];
        } else if (VitoBOutputInt == 3){
            VitoBPaperString = BPaperArticlePieces[11];
        }

        if (GuyBOutputInt == 1){
            GuyBPaperString = BPaperArticlePieces[6];
        } else if (GuyBOutputInt == 2){
            GuyBPaperString = BPaperArticlePieces[7];
        } else if (GuyBOutputInt == 3){
            GuyBPaperString = BPaperArticlePieces[8];
        }
        if (FranzBOutputInt == 1){
            FranzBPaperString = BPaperArticlePieces[12];
        } else if (FranzBOutputInt == 2){
            FranzBPaperString = BPaperArticlePieces[13];
        } else if (FranzBOutputInt == 3){
            FranzBPaperString = BPaperArticlePieces[14];
        }

        if (BrightonBOutputInt == 1){
            BrightonBPaperString = BPaperArticlePieces[0];
        } else if (BrightonBOutputInt == 2){
            BrightonBPaperString = BPaperArticlePieces[1];
        } else if (BrightonBOutputInt == 3){
            BrightonBPaperString = BPaperArticlePieces[2];
        }


    }

    public void ComPieceCalculator(){
        
        //If C (Comp)
        if (BorisCOutputInt == 1){
            BorisCPaperString = CPaperArticlePieces[4];

        } else if (BorisCOutputInt == 2){
            BorisCPaperString = CPaperArticlePieces[5];
        } else if (BorisCOutputInt == 3){
            BorisCPaperString = CPaperArticlePieces[6];
        }

        if (VitoCOutputInt == 1){
            VitoCPaperString = CPaperArticlePieces[9];

        } else if (VitoCOutputInt == 2){
            VitoCPaperString = CPaperArticlePieces[10];
        } else if (VitoCOutputInt == 3){
            VitoCPaperString = CPaperArticlePieces[11];
        }

        if (GuyCOutputInt == 1){
            GuyCPaperString = CPaperArticlePieces[6];
        } else if (VitoBOutputInt == 2){
             GuyCPaperString = CPaperArticlePieces[7];
        } else if (VitoBOutputInt == 3){
             GuyCPaperString = CPaperArticlePieces[8];
        }

        if (FranzCOutputInt == 1){
            FranzCPaperString = CPaperArticlePieces[12];
        } else if (FranzCOutputInt == 2){
            FranzCPaperString = CPaperArticlePieces[13];
        } else if (FranzCOutputInt == 3){
            FranzCPaperString = CPaperArticlePieces[14];
        }

        if (BrightonCOutputInt == 1){
            BrightonCPaperString = CPaperArticlePieces[0];
        } else if (BrightonCOutputInt == 2){
            BrightonCPaperString = CPaperArticlePieces[1];
        } else if (BrightonCOutputInt == 3){
            BrightonCPaperString = CPaperArticlePieces[2];
        }
    }


    
    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt;
        //PAPER PIECING
        AngPieceCalculator();
        FearPieceCalculator();
        ComPieceCalculator();

        AngryNewspaper = BrightonAPaperString + "\n" + BorisAPaperString + "\n" + GuyAPaperString + "\n" + VitoAPaperString + "\n" + FranzAPaperString;
        FearfulNewspaper = BrightonBPaperString + "\n" + BorisBPaperString + "\n" + GuyBPaperString + "\n" + VitoBPaperString + "\n" + FranzBPaperString;
        CompassionateNewspaper = BrightonCPaperString + "\n" + BorisCPaperString + "\n" + GuyCPaperString + "\n" + VitoCPaperString + "\n" + FranzCPaperString;

        //For determining which paper to print when they're equal
        if (FearfulPaper == AngryPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = AngryNewspaper; //newspaperPrints[0]; //need to change this for the different outputs
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = FearfulNewspaper; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }   
        }

        if (FearfulPaper == CompassionatePaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = FearfulNewspaper; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
           }
            else{
                PlayerNewspaper = CompassionateNewspaper; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (CompassionatePaper == AngryPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = CompassionateNewspaper; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = AngryNewspaper; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }
        }

        if (CompassionatePaper == FearfulPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = CompassionateNewspaper; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
           }
            else{
                PlayerNewspaper = FearfulNewspaper; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
            }
        }

        if (AngryPaper == CompassionatePaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
                PlayerNewspaper = AngryNewspaper; //newspaperPrints[1];
                PlayerHeadline = newspaperHeadlines[1];
            }
            else{
                PlayerNewspaper = CompassionateNewspaper; //newspaperPrints[2];
                PlayerHeadline = newspaperHeadlines[2];
            }    
        }

        if (AngryPaper == FearfulPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1){
            PlayerNewspaper = AngryNewspaper; //newspaperPrints[1];
            PlayerHeadline = newspaperHeadlines[1];
           }   
            else{
                PlayerNewspaper = FearfulNewspaper; //newspaperPrints[0];
                PlayerHeadline = newspaperHeadlines[0];
            }    
        }
        //Brighton: 0,1,2 Boris: 3,4,5 Vito: 6,7,8 Guy: 9,10,11 Franz:, 12,13,14
        //if they are not equal, it'll jump over here
        if (FearfulPaper > CompassionatePaper && FearfulPaper > AngryPaper){
           PlayerNewspaper = FearfulNewspaper;
           PlayerHeadline = newspaperHeadlines[0];
        }
        else if (AngryPaper > CompassionatePaper && AngryPaper > FearfulPaper){
            PlayerNewspaper = AngryNewspaper;
            PlayerHeadline = newspaperHeadlines[1];
        }
        else if (CompassionatePaper > FearfulPaper && CompassionatePaper > AngryPaper){
            PlayerNewspaper = CompassionateNewspaper;
            PlayerHeadline = newspaperHeadlines[2];
        }
    }
}
