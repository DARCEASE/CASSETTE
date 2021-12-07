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

    // MAKE A VARIABLE FOR THE DROPDOWN ITSELF 
    public Dropdown NovakDPOne;
    public Dropdown NovakDPTwo;
    public Dropdown NovakDPThree;

    public Dropdown JimDPOne;
    public Dropdown JimDPTwo;
    public Dropdown JimDPThree;

    public Dropdown JuliaDPOne;
    public Dropdown JuliaDPTwo;
    public Dropdown JuliaDPThree;

    public Dropdown MichaelDPOne;
    public Dropdown MichaelDPTwo;
    public Dropdown MichaelDPThree;

    public Dropdown MaxDPOne;
    public Dropdown MaxDPTwo;
    public Dropdown MaxDPThree;

    //UI TEXT THAT WILL HOLD ALL STRING CHANGES
    public Text JimNewspaperA;
    public Text JimNewspaperB;
    public Text JimNewspaperC;

    public Text JuliaNewspaperA;
    public Text JuliaNewspaperB;
    public Text JuliaNewspaperC;

    public Text MichaelNewspaperA;
    public Text MichaelNewspaperB;
    public Text MichaelNewspaperC;

    public Text MaxNewspaperA;
    public Text MaxNewspaperB;
    public Text MaxNewspaperC;

    public Text NovakNewspaperA;
    public Text NovakNewspaperB;
    public Text NovakNewspaperC;



    // establish all string variables that can be changed. and assign them on a UI text 

    //Novak
    public string novakInfoA; //container that will hold selected option for A
    public string novakInfoB; //B
    public string novakInfoC; //C

    //Jim 
    public string jimInfoA; //container that will hold selected option  for A 
    public string jimInfoB; //B
    public string jimInfoC; //C

    //Julia 
    public string juliaInfoA; //container that will hold selected option A
    public string juliaInfoB; //B
    public string juliaInfoC; //C

    //Michael 
    public string michaelInfoA; //container that will hold selected option A
    public string michaelInfoB; //B
    public string michaelInfoC; //C

    //Max
    public string maxInfoA; //container that will hold selected option A
    public string maxInfoB; //B
    public string maxInfoC; //C


    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //NOVAK
    public void NovakDropA()
    {
        if (NovakDPOne.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 1 Opt 1");
            novakInfoA = "The detective assigned to the case.";// change the text in the newspaper to be a certain line
            NovakNewspaperA.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 27th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined." + " Detective Novak is " + novakInfoA;
            
        }
        else if (NovakDPOne.value == 2)
        {
            Debug.Log("NOV. Drop 1 Opt 2");
            novakInfoB = "the detective the case was handed off to.";// change the text in the newspaper to be a certain line
            NovakNewspaperA.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 27th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined." + "Detective Novak is " + novakInfoB;
        }
        else if (NovakDPOne.value == 3)
        {
            Debug.Log("NOV. Drop 1 Opt 3");
            novakInfoC = "on top of the case.";// change the text in the newspaper to be a certain line
            NovakNewspaperA.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 27th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined."+ " Detective Novak is " + novakInfoC ;
        }
    }
    public void NovakDropB() // WHO second dropdown for Novak
    {
        if (NovakDPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 2 Opt 1");
            novakInfoB = "is passionate about getting justice.";// change the text in the newspaper to be a certain line
            NovakNewspaperB.text = "Novak " + novakInfoB;
        }
        else if (NovakDPTwo.value == 2)
        {
            Debug.Log("NOV. Drop 2 Opt 2");
            novakInfoB = "is determined to uncover all the facts.";// change the text in the newspaper to be a certain line
            NovakNewspaperB.text = "Novak " + novakInfoB; 
        }
        else if (NovakDPTwo.value == 3)
        {
            Debug.Log("NOV. Drop 2 Opt 3");
            novakInfoB = "is taking a passive stance towards solving the case.";// change the text in the newspaper to be a certain line
            NovakNewspaperB.text = "Novak " + novakInfoB ;
        }
    }
    public void NovakDropC()
    {
        if (NovakDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 3 Opt 1");
            novakInfoC = "Novak seems more interested in gossip than finidn the truth.";// change the text in the newspaper to be a certain line
            NovakNewspaperC.text = "While it is clear that Mr. Evergreen’s death was the apparent result of a fall from a great height, the circumstances of that fall are the subject of an active and ongoing investigation, and the NYPD does not wish to speculate on those circumstances at this time." +  "But " + novakInfoC;
        }
        else if (NovakDPThree.value == 2)
        {
            Debug.Log("NOV. Drop 3 Opt 2");
            novakInfoC = "Novak is determined to uncover the thruth, no matter what.";// change the text in the newspaper to be a certain line
            NovakNewspaperC.text = "While it is clear that Mr. Evergreen’s death was the apparent result of a fall from a great height, the circumstances of that fall are the subject of an active and ongoing investigation, and the NYPD does not wish to speculate on those circumstances at this time."  + "But " + novakInfoC;
          
        }
        else if (NovakDPThree.value == 3)
        {
            Debug.Log("NOV. Drop 3 Opt 3");
            novakInfoC = "Novak is following up on any and all leads.";// change the text in the newsaper to be a certain line
            NovakNewspaperC.text = "While it is clear that Mr. Evergreen’s death was the apparent result of a fall from a great height, the circumstances of that fall are the subject of an active and ongoing investigation, and the NYPD does not wish to speculate on those circumstances at this time." + "But " + novakInfoC;
        }
    }

    //JIM 
    public void JimDropA() // JIM SENTENCE 1
    {
        if (JimDPOne.value == 1) 
        {
            Debug.Log("JIM. Drop 1 Opt 1");
            jimInfoA = "Mr. Evergreen's ridiculous son.";// change the text in the newspaper to be a certain line
            JimNewspaperA.text = "" + "And " + jimInfoA;
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("Char_Name. Drop 1 Opt 2");
            jimInfoA = "Mr.Evergreen's grieving son.";// change the text in the newspaper to be a certain line
            JimNewspaperA.text = "" + "And " + jimInfoA;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("Char_Name. Drop 1 Opt 3");
            jimInfoA = "Mr. Evergreen's resentful son.";// change the text in the newspaper to be a certain line
            JimNewspaperA.text = "" + "And " + jimInfoA;
        }
    }
    public void JimDropB() // JIM SENTENCE 2
    {
        if (JimDPTwo.value == 1) 
        {
            Debug.Log("JIM. Drop 2 Opt 1");
            jimInfoB = "He knew Mr. Evergreen better than anyone else";// change the text in the newspaper to be a certain line
            JimNewspaperB.text = "" + "And " + jimInfoB;
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 2 Opt 2");
            jimInfoB = "used to know Mr.Evergreen well";// change the text in the newspaper to be a certain line
            JimNewspaperB.text = "" + "And " + jimInfoB;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 2 Opt 3");
            jimInfoB = "hardly knew Mr.Evergreen at all";// change the text in the newspaper to be a certain line
            JimNewspaperB.text = "" + "And " + jimInfoB;
        }
    }
    public void JimDropC() // JIM SENTENCE 3 
    {
        if (JimDPThree.value == 1) 
        {
            Debug.Log("JIM. Drop 3 Opt 1");
            jimInfoC = "loved Mr. Evergreen";// change the text in the newspaper to be a certain line
            JimNewspaperC.text = "" + "And " + jimInfoC;
        }
        else if (JimDPThree.value == 2)
        {
            Debug.Log("JIM. Drop 3 Opt 2");
            jimInfoC = "had a troubled relationship with Mr.Evergreen";// change the text in the newspaper to be a certain line
            JimNewspaperC.text = "" + "And " + jimInfoC;
        }
        else if (JimDPThree.value == 3)
        {
            Debug.Log("JIM. Drop 3 Opt 3");
            jimInfoC = "hated Mr. Evergreen";// change the text in the newspaper to be a certain line
            JimNewspaperC.text = "" + "And " + jimInfoC; ;
        }
        
    }

    //JULIA 

    public void JuliaDropA()
    {
        if (JuliaDPOne.value == 1) 
        {
            Debug.Log("JULIA. Drop 1 Opt 1");
            juliaInfoA = "Mr Evergreen's daughter";// change the text in the newspaper to be a certain line
            JuliaNewspaperA.text = "" + "And " + juliaInfoA;
        }
        else if (JuliaDPOne.value == 2)
        {
            Debug.Log("JULIA. Drop 1 Opt 2");
            juliaInfoA = "Mr. Evergreen's pregnant daughter.";// change the text in the newspaper to be a certain line
            JuliaNewspaperA.text = "" + "And " + juliaInfoA;
        }
        else if (JuliaDPOne.value == 3)
        {
            Debug.Log("JULIA. Drop 1 Opt 3");
            juliaInfoA = "a soon-to-be mother";// change the text in the newspaper to be a certain line
            JuliaNewspaperA.text = "" + "And " + juliaInfoA;
        }
    }
    public void JuliaDropB()
    {
        if (JuliaDPTwo.value == 1)
        {
            Debug.Log("JULIA. Drop 2 Opt 1");
            juliaInfoB = "loved her father very much";// change the text in the newspaper to be a certain line
            JuliaNewspaperB.text = "" + "And " + juliaInfoB;
        }
        else if (JuliaDPTwo.value == 2)
        {
            Debug.Log("JULIA. Drop 2 Opt 2");
            juliaInfoB = "is in denial about who her father was";// change the text in the newspaper to be a certain line
            JuliaNewspaperB.text = "" + "And " + juliaInfoB;
        }
        else if (JuliaDPTwo.value == 3)
        {
            Debug.Log("JULIA. Drop 2 Opt 3");
            juliaInfoB = "takes a neutral stance towards her father";// change the text in the newspaper to be a certain line
            JuliaNewspaperB.text = "" + "And " + juliaInfoB;
        }
    }
    public void JuliaDropC()
    {
        if (JuliaDPThree.value == 1)
        {
            Debug.Log("JULIA. Drop 3 Opt 1");
            juliaInfoC = "reacted poorly to questions about him";// change the text in the newspaper to be a certain line
            JuliaNewspaperC.text = "" + "And " + juliaInfoC;
        }
        else if (JuliaDPTwo.value == 2)
        {
            Debug.Log("JULIA. Drop 3 Opt 2");
            juliaInfoC = "was open about who her father was";// change the text in the newspaper to be a certain line
            JuliaNewspaperC.text = "" + "And " + juliaInfoC;
        }
        else if (JuliaDPTwo.value == 3)
        {
            Debug.Log("JULIA. Drop 3 Opt 3");
            juliaInfoC = "approved of her father's actions and lifestyle";// change the text in the newspaper to be a certain line
            JuliaNewspaperC.text = "" + "And " + juliaInfoC;
        }
    }

    //MICHAEL 
    public void MichaelDropA()
    {
        if (MichaelDPOne.value == 1)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 1");
            michaelInfoA = "Mr. Evergreen's friend";// change the text in the newspaper to be a certain line
            MichaelNewspaperA.text = "" + "And " + michaelInfoA;
        }
        else if (MichaelDPOne.value == 2)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 2");
            michaelInfoA = "Mr. Evergreen's anonymous Boyfriend";// change the text in the newspaper to be a certain line
            MichaelNewspaperA.text = "" + "And " + michaelInfoA;
        }
        else if (MichaelDPOne.value == 3)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 3");
            michaelInfoA = "Michael Bailey, Mr. Evergreen's boyfriend";// change the text in the newspaper to be a certain line
            MichaelNewspaperA.text = "" + "And " + michaelInfoA;
        }
    }
    public void MichaelDropB()
    {
        if (MichaelDPTwo.value == 1)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 1");
            michaelInfoB = "is in the navy";// change the text in the newspaper to be a certain line
            MichaelNewspaperB.text = "" + "And " + michaelInfoB;
        }
        else if (JuliaDPTwo.value == 2)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 2");
            michaelInfoB = "is a saucy sailor";// change the text in the newspaper to be a certain line
            MichaelNewspaperB.text = "" + "And " + michaelInfoB;
        }
        else if (JuliaDPTwo.value == 3)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 3");
            michaelInfoB = "is a victim of an oppresive system";// change the text in the newspaper to be a certain line
            MichaelNewspaperB.text = "" + "And " + michaelInfoB;
        }
    }
    public void MichaelDropC()
    {
            if (JuliaDPThree.value == 1)
            {
                Debug.Log("MICHAEL Drop 3 Opt 1");
                michaelInfoC = "regrets his relationship with Mr. Evergreen";// change the text in the newspaper to be a certain line
                MichaelNewspaperC.text = "" + "And " + michaelInfoC;
            }
            else if (JuliaDPTwo.value == 2)
            {
                Debug.Log("MICHAEL. Drop 3 Opt 2");
                michaelInfoC = "was close with Mr. Evergreen";// change the text in the newspaper to be a certain line
                MichaelNewspaperC.text = "" + "And " + michaelInfoC;
            }
            else if (JuliaDPTwo.value == 3)
            {
                Debug.Log("MICHAEL. Drop 3 Opt 3");
                michaelInfoC = "cared deeply for Mr. Evergreen";// change the text in the newspaper to be a certain line
                MichaelNewspaperC.text = "" + "And " + michaelInfoC;
            }
        }

    //MAX
    public void MaxDropA()
    {
        if (MaxDPOne.value == 1)
        {
            Debug.Log("MAX. Drop 1 Opt 1");
            maxInfoA = "Mr. Evergreen's friend and business partner";// change the text in the newspaper to be a certain line
            MaxNewspaperA.text = "" + "And " + maxInfoA;
        }
        else if (MichaelDPOne.value == 2)
        {
            Debug.Log("MAX. Drop 1 Opt 2");
            maxInfoA = "Mr. Evergreen's business partner";// change the text in the newspaper to be a certain line
            MaxNewspaperA.text = "" + "And " + maxInfoA;
        }
        else if (MichaelDPOne.value == 3)
        {
            Debug.Log("MAX. Drop 1 Opt 3");
            maxInfoA = "Mr. Evergreen's subordinate";// change the text in the newspaper to be a certain line
            MaxNewspaperA.text = "" + "And " + maxInfoA;
        }
    }
    public void MaxDropB()
    {
        if (MaxDPTwo.value == 1)
        {
            Debug.Log("MAX. Drop 2 Opt 1");
            maxInfoB = "is cold and businesslike";// change the text in the newspaper to be a certain line
            MaxNewspaperB.text = "" + "And " + maxInfoB;
        }
        else if (MaxDPTwo.value == 2)
        {
            Debug.Log("MAX. Drop 2 Opt 2");
            maxInfoB = "is a bitch";// change the text in the newspaper to be a certain line
            MaxNewspaperB.text = "" + "And " + maxInfoB;
        }
        else if (MaxDPTwo.value == 3)
        {
            Debug.Log("MAX. Drop 2 Opt 3");
            maxInfoB = "is a woman doing her best to make it in a man's world";// change the text in the newspaper to be a certain line
            MaxNewspaperB.text = "" + "And " + maxInfoB;
        }
    }
    public void MaxDropC()
    {
        if (MaxDPThree.value == 1)
        {
            Debug.Log("MAX. Drop 3 Opt 1");
            maxInfoC = "refused to answer questions about Mr. Evergreen's personal life";// change the text in the newspaper to be a certain line
            MaxNewspaperC.text = "" + "And " + maxInfoC;
        }
        else if (MaxDPThree.value == 2)
        {
            Debug.Log("MAX. Drop 3 Opt 2");
            maxInfoC = "did not know anything about Mr. Evergreen's personal life";// change the text in the newspaper to be a certain line
            MaxNewspaperC.text = "" + "And " + maxInfoC;
        }
        else if (MaxDPThree.value == 3)
        {
            Debug.Log("MAX. Drop 3 Opt 3");
            maxInfoC = "knew more than she could say about MR.Evergreen's personal life";// change the text in the newspaper to be a certain line
            MaxNewspaperC.text = "" + "And " + maxInfoC;
        }
    }
}
