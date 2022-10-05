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
    public string PlayerNewspaper;
    public Text finalNewspaper;
    [TextArea]
    [SerializeField] string[] newspaperPrints;

    // MAKE A VARIABLE FOR THE DROPDOWN ITSELF 
    public Dropdown NovakDPOne, NovakDPTwo, NovakDPThree;

    public Dropdown JimDPOne, JimDPTwo, JimDPThree;

    public Dropdown JuliaDPOne, JuliaDPTwo, JuliaDPThree;

    public Dropdown MichaelDPOne, MichaelDPTwo, MichaelDPThree;

    public Dropdown MaxDPOne, MaxDPTwo, MaxDPThree;

    //UI TEXT THAT WILL HOLD ALL STRING CHANGES
    [SerializeField] string[] jimNewspaperOptions;
    [SerializeField] string[] juliaNewspaperOptions;
    [SerializeField] string[] michaelNewspaperOptions;
    [SerializeField] string[] maxNewspaperOptions;
    [SerializeField] string[] novakNewspaperOptions;

    // establish all string variables that can be changed. and assign them on a UI text 
    [SerializeField] string[] novakInfoOptions;
    [SerializeField] string[] jimInfoOptions;
    [SerializeField] string[] juliaInfoOptions;
    [SerializeField] string[] michaelInfoOptions;
    [SerializeField] string[] maxInfoOptions;

    //Values
    [SerializeField] int muckrakerPaper, tabloidPaper, statusQuoPaper;


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

    //NOVAK
    public void NovakDropA()
    {
        if (NovakDPOne.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 1 Opt 1");
            novakNewspaperOptions[0] = novakInfoOptions[0];
            statusQuoPaper+=1;
        }
        else if (NovakDPOne.value == 2)
        {
            Debug.Log("NOV. Drop 1 Opt 2");
            novakNewspaperOptions[0] = novakInfoOptions[1];
            muckrakerPaper+=1;
        }
        else if (NovakDPOne.value == 3)
        {
            Debug.Log("NOV. Drop 1 Opt 3");
            novakNewspaperOptions[0] = novakInfoOptions[2];
            tabloidPaper+=1;
        }
    }
    public void NovakDropB() // WHO second dropdown for Novak
    {
        if (NovakDPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 2 Opt 1");
            novakNewspaperOptions[1] = novakInfoOptions[3];
            tabloidPaper+=1;
        }
        else if (NovakDPTwo.value == 2)
        {
            Debug.Log("NOV. Drop 2 Opt 2");
            novakNewspaperOptions[1] = novakInfoOptions[4];
            statusQuoPaper+=1;
        }
        else if (NovakDPTwo.value == 3)
        {
            Debug.Log("NOV. Drop 2 Opt 3");
            novakNewspaperOptions[1] = novakInfoOptions[5];
            muckrakerPaper+=1;
            
        } 
    }
    public void NovakDropC()
    {
        if (NovakDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 3 Opt 1");
            novakNewspaperOptions[2] = novakInfoOptions[6];
            statusQuoPaper+=1;
        }
        else if (NovakDPThree.value == 2)
        {
            Debug.Log("NOV. Drop 3 Opt 2");
            novakNewspaperOptions[2] = novakInfoOptions[7];
            muckrakerPaper+=1;
        }
        else if (NovakDPThree.value == 3)
        {
            Debug.Log("NOV. Drop 3 Opt 3");
            novakNewspaperOptions[2] = novakInfoOptions[8];
            tabloidPaper+=1;
        }
    }

    //JIM 
    public void JimDropA() // JIM SENTENCE 1
    {
        if (JimDPOne.value == 1) 
        {
            Debug.Log("JIM. Drop 1 Opt 1");
            jimNewspaperOptions[0] = jimInfoOptions[0];
            tabloidPaper+=1;
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 1 Opt 2");
            jimNewspaperOptions[0] = jimInfoOptions[1];
            statusQuoPaper+=1;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 1 Opt 3");
            jimNewspaperOptions[0] = jimInfoOptions[2];
            muckrakerPaper+=1;
        }
    }
    public void JimDropB() // JIM SENTENCE 2
    {
        if (JimDPTwo.value == 1) 
        {
            Debug.Log("JIM. Drop 2 Opt 1");
            jimNewspaperOptions[1] = jimInfoOptions[3];
            statusQuoPaper+=1;
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 2 Opt 2");
            jimNewspaperOptions[1] = jimInfoOptions[4];
            muckrakerPaper+=1;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 2 Opt 3");
            jimNewspaperOptions[1] = jimInfoOptions[5];
            tabloidPaper+=1;
        }
    }
    public void JimDropC() // JIM SENTENCE 3 
    {
        if (JimDPThree.value == 1) 
        {
            Debug.Log("JIM. Drop 3 Opt 1");
            jimNewspaperOptions[2] = jimInfoOptions[6];
            muckrakerPaper+=1;
        }
        else if (JimDPThree.value == 2)
        {
            Debug.Log("JIM. Drop 3 Opt 2");
            jimNewspaperOptions[2] = jimInfoOptions[7];
            statusQuoPaper+=1;
        }
        else if (JimDPThree.value == 3)
        {
            Debug.Log("JIM. Drop 3 Opt 3");
            jimNewspaperOptions[2] = jimInfoOptions[8];
            tabloidPaper+=1;
        } 
    }

    //JULIA 

    public void JuliaDropA()
    {
        if (JuliaDPOne.value == 1) 
        {
            Debug.Log("JULIA. Drop 1 Opt 1");
            juliaNewspaperOptions[0] = juliaInfoOptions[0];
            statusQuoPaper+=1;
        }
        else if (JuliaDPOne.value == 2)
        {
            Debug.Log("JULIA. Drop 1 Opt 2");
            juliaNewspaperOptions[0] = juliaInfoOptions[1];
            tabloidPaper+=1;
        }
        else if (JuliaDPOne.value == 3)
        {
            Debug.Log("JULIA. Drop 1 Opt 3");
            juliaNewspaperOptions[0] = juliaInfoOptions[2];
            muckrakerPaper+=1;
        }
    }
    public void JuliaDropB()
    {
        if (JuliaDPTwo.value == 1)
        {
            Debug.Log("JULIA. Drop 2 Opt 1");
            juliaNewspaperOptions[1] = juliaInfoOptions[3];
            muckrakerPaper+=1;
        }
        else if (JuliaDPTwo.value == 2)
        {
            Debug.Log("JULIA. Drop 2 Opt 2");
            juliaNewspaperOptions[1] = juliaInfoOptions[4];
            statusQuoPaper+=1;
        }
        else if (JuliaDPTwo.value == 3)
        {
            Debug.Log("JULIA. Drop 2 Opt 3");
            juliaNewspaperOptions[1] = juliaInfoOptions[5];
            tabloidPaper+=1;
        }
    }
    public void JuliaDropC()
    {
        if (JuliaDPThree.value == 1)
        {
            Debug.Log("JULIA. Drop 3 Opt 1");
            juliaNewspaperOptions[2] = juliaInfoOptions[6];
            tabloidPaper+=1;
        }
        else if (JuliaDPThree.value == 2)
        {
            Debug.Log("JULIA. Drop 3 Opt 2");
            juliaNewspaperOptions[2] = juliaInfoOptions[7];
            statusQuoPaper+=1;
        }
        else if (JuliaDPThree.value == 3)
        {
            Debug.Log("JULIA. Drop 3 Opt 3");
            juliaNewspaperOptions[2] = juliaInfoOptions[8];
            muckrakerPaper+=1;
        }
    }

    //MICHAEL 
    public void MichaelDropA()
    {
        if (MichaelDPOne.value == 1)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 1");
            michaelNewspaperOptions[0] = michaelInfoOptions[0];
            statusQuoPaper+=1;
        }
        else if (MichaelDPOne.value == 2)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 2");
            michaelNewspaperOptions[0] = michaelInfoOptions[1];
            muckrakerPaper+=1;
        }
        else if (MichaelDPOne.value == 3)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 3");
            michaelNewspaperOptions[0] = michaelInfoOptions[2];
            tabloidPaper+=1;
        }
    }
    public void MichaelDropB()
    {
        if (MichaelDPTwo.value == 1)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 1");
            michaelNewspaperOptions[1] = michaelInfoOptions[3];
            statusQuoPaper+=1;
        }
        else if (JuliaDPTwo.value == 2)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 2");
            michaelNewspaperOptions[1] = michaelInfoOptions[4];
            tabloidPaper+=1;
        }
        else if (JuliaDPTwo.value == 3)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 3");
            michaelNewspaperOptions[1] = michaelInfoOptions[5];
            muckrakerPaper+=1;
        }
    }
    public void MichaelDropC()
    {
            if (MichaelDPThree.value == 1)
            {
                Debug.Log("MICHAEL Drop 3 Opt 1");
                michaelNewspaperOptions[2] = michaelInfoOptions[6];
                tabloidPaper+=1;
            }
            else if (MichaelDPThree.value == 2)
            {
                Debug.Log("MICHAEL. Drop 3 Opt 2");
                michaelNewspaperOptions[2] = michaelInfoOptions[7];
                statusQuoPaper+=1;
            }
            else if (MichaelDPThree.value == 3)
            {
                Debug.Log("MICHAEL. Drop 3 Opt 3");
                michaelNewspaperOptions[2] = michaelInfoOptions[8];
                muckrakerPaper+=1;
            }
        }

    //MAX
    public void MaxDropA()
    {
        if (MaxDPOne.value == 1)
        {
            Debug.Log("MAX. Drop 1 Opt 1");
            maxNewspaperOptions[0] = maxInfoOptions[0];
            muckrakerPaper+=1;
        }
        else if (MichaelDPOne.value == 2)
        {
            Debug.Log("MAX. Drop 1 Opt 2");
            michaelNewspaperOptions[0] = michaelInfoOptions[1];
            statusQuoPaper+=1;
        }
        else if (MichaelDPOne.value == 3)
        {
            Debug.Log("MAX. Drop 1 Opt 3");
            michaelNewspaperOptions[0] = michaelInfoOptions[2];
            tabloidPaper+=1;
        }
    }
    public void MaxDropB()
    {
        if (MaxDPTwo.value == 1)
        {
            Debug.Log("MAX. Drop 2 Opt 1");
            michaelNewspaperOptions[1] = michaelInfoOptions[3];
            statusQuoPaper+=1;
        }
        else if (MaxDPTwo.value == 2)
        {
            Debug.Log("MAX. Drop 2 Opt 2");
            michaelNewspaperOptions[1] = michaelInfoOptions[4];
            tabloidPaper+=1;
        }
        else if (MaxDPTwo.value == 3)
        {
            Debug.Log("MAX. Drop 2 Opt 3");
            michaelNewspaperOptions[1] = michaelInfoOptions[5];
            muckrakerPaper+=1;
        }
    }
    public void MaxDropC()
    {
        if (MaxDPThree.value == 1)
        {
            Debug.Log("MAX. Drop 3 Opt 1");
            michaelNewspaperOptions[2] = michaelInfoOptions[6];
            tabloidPaper+=1;
        }
        else if (MaxDPThree.value == 2)
        {
            Debug.Log("MAX. Drop 3 Opt 2");
            michaelNewspaperOptions[2] = michaelInfoOptions[7];
            statusQuoPaper+=1;
        }
        else if (MaxDPThree.value == 3)
        {
            Debug.Log("MAX. Drop 3 Opt 3");
            michaelNewspaperOptions[2] = michaelInfoOptions[8];
            muckrakerPaper+=1;
        }
    }
    public void NewspaperPrint() // using this to test things 
    {
        int finalPaperInt; 
        
        //For determining which paper to print when they're equal
        if (muckrakerPaper == statusQuoPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1)
                PlayerNewspaper = newspaperPrints[0];
            else
                PlayerNewspaper = newspaperPrints[1];
        }

        if (muckrakerPaper == tabloidPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1)
                PlayerNewspaper = newspaperPrints[0];
            else
                PlayerNewspaper = newspaperPrints[2];
        }

        if (tabloidPaper == statusQuoPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1)
                PlayerNewspaper = newspaperPrints[2];
            else
                PlayerNewspaper = newspaperPrints[1];
        }

        if (tabloidPaper == muckrakerPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1)
                PlayerNewspaper = newspaperPrints[2];
            else
                PlayerNewspaper = newspaperPrints[0];
        }

        if (statusQuoPaper == tabloidPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1)
                PlayerNewspaper = newspaperPrints[1];
            else
                PlayerNewspaper = newspaperPrints[2];
        }

         if (statusQuoPaper == muckrakerPaper){
           finalPaperInt = Random.Range(1, 2);
           if (finalPaperInt == 1)
                PlayerNewspaper = newspaperPrints[1];
            else
                PlayerNewspaper = newspaperPrints[0];
        }

        //if they are not equal, it'll jump over here

        if (muckrakerPaper > tabloidPaper && muckrakerPaper > statusQuoPaper)
            PlayerNewspaper = newspaperPrints[0];
        else if (tabloidPaper > muckrakerPaper && tabloidPaper > statusQuoPaper)
            PlayerNewspaper = newspaperPrints[1];
        else if (statusQuoPaper > tabloidPaper && statusQuoPaper > muckrakerPaper)
            PlayerNewspaper = newspaperPrints[2];


        finalNewspaper.text = PlayerNewspaper;

    }
}


