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
    public string JimNewspaperA;
    public string JimNewspaperB;
    public string JimNewspaperC;

    public string JuliaNewspaperA;
    public string JuliaNewspaperB;
    public string JuliaNewspaperC;

    public string MichaelNewspaperA;
    public string MichaelNewspaperB;
    public string MichaelNewspaperC;

    public string MaxNewspaperA;
    public string MaxNewspaperB;
    public string MaxNewspaperC;

    public string NovakNewspaperA;
    public string NovakNewspaperB;
    public string NovakNewspaperC;



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
        NewspaperPrint();
    }

    //NOVAK
    public void NovakDropA()
    {
        if (NovakDPOne.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 1 Opt 1");
            novakInfoA = "the detective assigned to the case,";// change the text in the newspaper to be a certain line
            NovakNewspaperA = novakInfoA;
        }
        else if (NovakDPOne.value == 2)
        {
            Debug.Log("NOV. Drop 1 Opt 2");
            novakInfoA = "the detective the case was handed off to,";// change the text in the newspaper to be a certain line
            NovakNewspaperA = novakInfoA;
        }
        else if (NovakDPOne.value == 3)
        {
            Debug.Log("NOV. Drop 1 Opt 3");
            novakInfoA = "the detective on top of the case,";// change the text in the newspaper to be a certain line
            NovakNewspaperA = novakInfoA;
        }
    }
    public void NovakDropB() // WHO second dropdown for Novak
    {
        if (NovakDPTwo.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 2 Opt 1");
            novakInfoB = "seems more interested in gossip than finding the truth.";// change the text in the newspaper to be a certain line
            NovakNewspaperB =novakInfoB;
        }
        else if (NovakDPTwo.value == 2)
        {
            Debug.Log("NOV. Drop 2 Opt 2");
            novakInfoB = "is determined to get justice for Mr.Evergreen, no matter what";// change the text in the newspaper to be a certain line
            NovakNewspaperB = novakInfoB; 
        }
        else if (NovakDPTwo.value == 3)
        {
            Debug.Log("NOV. Drop 2 Opt 3");
            novakInfoB = "is following up on any and all leads";// change the text in the newspaper to be a certain line
            NovakNewspaperB = novakInfoB;
            
        } 
    }
    public void NovakDropC()
    {
        if (NovakDPThree.value == 1) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 3 Opt 1");
            novakInfoC = "does not wish to speculate on the manner of death at this time.";// change the text in the newspaper to be a certain line
            NovakNewspaperC = novakInfoC;
        }
        else if (NovakDPThree.value == 2)
        {
            Debug.Log("NOV. Drop 3 Opt 2");
            novakInfoC = "is considering the possiblity of homicide.";// change the text in the newspaper to be a certain line
            NovakNewspaperC = novakInfoC;
        }
        else if (NovakDPThree.value == 3)
        {
            Debug.Log("NOV. Drop 3 Opt 3");
            novakInfoC = "is considering the possibility the Mr. Evergreen took his life.";// change the text in the newsaper to be a certain line
            NovakNewspaperC = novakInfoC;
        }
    }

    //JIM 
    public void JimDropA() // JIM SENTENCE 1
    {
        if (JimDPOne.value == 1) 
        {
            Debug.Log("JIM. Drop 1 Opt 1");
            jimInfoA = "ridiculous son";// change the text in the newspaper to be a certain line
            JimNewspaperA = jimInfoA;
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 1 Opt 2");
            jimInfoA = "grieving son";// change the text in the newspaper to be a certain line
            JimNewspaperA = jimInfoA;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 1 Opt 3");
            jimInfoA = "resentful son";// change the text in the newspaper to be a certain line
            JimNewspaperA = jimInfoA;
        }
    }
    public void JimDropB() // JIM SENTENCE 2
    {
        if (JimDPTwo.value == 1) 
        {
            Debug.Log("JIM. Drop 2 Opt 1");
            jimInfoB = "knew Mr. Evergreen better than anyone else";// change the text in the newspaper to be a certain line
            JimNewspaperB = jimInfoB;
        }
        else if (JimDPOne.value == 2)
        {
            Debug.Log("JIM. Drop 2 Opt 2");
            jimInfoB = "used to know Mr.Evergreen well";// change the text in the newspaper to be a certain line
            JimNewspaperB = jimInfoB;
        }
        else if (JimDPOne.value == 3)
        {
            Debug.Log("JIM. Drop 2 Opt 3");
            jimInfoB = "hardly knew Mr.Evergreen at all";// change the text in the newspaper to be a certain line
            JimNewspaperB = jimInfoB;
        }
    }
    public void JimDropC() // JIM SENTENCE 3 
    {
        if (JimDPThree.value == 1) 
        {
            Debug.Log("JIM. Drop 3 Opt 1");
            jimInfoC = "loved Mr. Evergreen";// change the text in the newspaper to be a certain line
            JimNewspaperC = jimInfoC;
        }
        else if (JimDPThree.value == 2)
        {
            Debug.Log("JIM. Drop 3 Opt 2");
            jimInfoC = "had a troubled relationship with Mr.Evergreen";// change the text in the newspaper to be a certain line
            JimNewspaperC = jimInfoC;
        }
        else if (JimDPThree.value == 3)
        {
            Debug.Log("JIM. Drop 3 Opt 3");
            jimInfoC = "hated Mr. Evergreen";// change the text in the newspaper to be a certain line
            JimNewspaperC = jimInfoC; ;
        }
        
    }

    //JULIA 

    public void JuliaDropA()
    {
        if (JuliaDPOne.value == 1) 
        {
            Debug.Log("JULIA. Drop 1 Opt 1");
            juliaInfoA = "daughter.";// change the text in the newspaper to be a certain line
            JuliaNewspaperA = juliaInfoA;
        }
        else if (JuliaDPOne.value == 2)
        {
            Debug.Log("JULIA. Drop 1 Opt 2");
            juliaInfoA = "emotional daughter.";// change the text in the newspaper to be a certain line
            JuliaNewspaperA = juliaInfoA;
        }
        else if (JuliaDPOne.value == 3)
        {
            Debug.Log("JULIA. Drop 1 Opt 3");
            juliaInfoA = "pregnant daughter.";// change the text in the newspaper to be a certain line
            JuliaNewspaperA = juliaInfoA;
        }
    }
    public void JuliaDropB()
    {
        if (JuliaDPTwo.value == 1)
        {
            Debug.Log("JULIA. Drop 2 Opt 1");
            juliaInfoB = "loved her father very much";// change the text in the newspaper to be a certain line
            JuliaNewspaperB = juliaInfoB;
        }
        else if (JuliaDPTwo.value == 2)
        {
            Debug.Log("JULIA. Drop 2 Opt 2");
            juliaInfoB = "takes a neutral stance towards her father";// change the text in the newspaper to be a certain line
            JuliaNewspaperB = juliaInfoB;
        }
        else if (JuliaDPTwo.value == 3)
        {
            Debug.Log("JULIA. Drop 2 Opt 3");
            juliaInfoB = "is in denial about who her father was";// change the text in the newspaper to be a certain line
            JuliaNewspaperB = juliaInfoB;
        }
    }
    public void JuliaDropC()
    {
        if (JuliaDPThree.value == 1)
        {
            Debug.Log("JULIA. Drop 3 Opt 1");
            juliaInfoC = "reacted poorly to questions about him";// change the text in the newspaper to be a certain line
            JuliaNewspaperC = juliaInfoC;
        }
        else if (JuliaDPThree.value == 2)
        {
            Debug.Log("JULIA. Drop 3 Opt 2");
            juliaInfoC = "was open about who her father was";// change the text in the newspaper to be a certain line
            JuliaNewspaperC = juliaInfoC;
        }
        else if (JuliaDPThree.value == 3)
        {
            Debug.Log("JULIA. Drop 3 Opt 3");
            juliaInfoC = "approved of her father's actions and lifestyle";// change the text in the newspaper to be a certain line
            JuliaNewspaperC = juliaInfoC;
        }
    }

    //MICHAEL 
    public void MichaelDropA()
    {
        if (MichaelDPOne.value == 1)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 1");
            michaelInfoA = "Lieutenant Michael Bailey, Mr. Evergreen’s friend,";// change the text in the newspaper to be a certain line
            MichaelNewspaperA = michaelInfoA;
        }
        else if (MichaelDPOne.value == 2)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 2");
            michaelInfoA = "Mr. Evergreen’s anonymous romantic partner,";// change the text in the newspaper to be a certain line
            MichaelNewspaperA = michaelInfoA;
        }
        else if (MichaelDPOne.value == 3)
        {
            Debug.Log("MICHAEL. Drop 1 Opt 3");
            michaelInfoA = "Lieutenant Michael Bailey, Mr. Evergreen’s long-term romantic partner,";// change the text in the newspaper to be a certain line
            MichaelNewspaperA = michaelInfoA;
        }
    }
    public void MichaelDropB()
    {
        if (MichaelDPTwo.value == 1)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 1");
            michaelInfoB = "a career sailor in the United States Navy ";// change the text in the newspaper to be a certain line
            MichaelNewspaperB =  michaelInfoB;
        }
        else if (JuliaDPTwo.value == 2)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 2");
            michaelInfoB = "is a saucy sailor ";// change the text in the newspaper to be a certain line
            MichaelNewspaperB = michaelInfoB;
        }
        else if (JuliaDPTwo.value == 3)
        {
            Debug.Log("MICHAEL. Drop 2 Opt 3");
            michaelInfoB = "a victim of an oppressive system ";// change the text in the newspaper to be a certain line
            MichaelNewspaperB = michaelInfoB;
        }
    }
    public void MichaelDropC()
    {
            if (MichaelDPThree.value == 1)
            {
                Debug.Log("MICHAEL Drop 3 Opt 1");
                michaelInfoC = "who regrets his relationship with Mr. Evergreen.";// change the text in the newspaper to be a certain line
                MichaelNewspaperC = michaelInfoC;
            }
            else if (MichaelDPThree.value == 2)
            {
                Debug.Log("MICHAEL. Drop 3 Opt 2");
                michaelInfoC = "who was close with Mr. Evergreen.";// change the text in the newspaper to be a certain line
                MichaelNewspaperC = michaelInfoC;
            }
            else if (MichaelDPThree.value == 3)
            {
                Debug.Log("MICHAEL. Drop 3 Opt 3");
                michaelInfoC = "who cared deeply for Mr. Evergreen.";// change the text in the newspaper to be a certain line
                MichaelNewspaperC = michaelInfoC;
            }
        }

    //MAX
    public void MaxDropA()
    {
        if (MaxDPOne.value == 1)
        {
            Debug.Log("MAX. Drop 1 Opt 1");
            maxInfoA = "Mr. Evergreen's friend and business partner who";// change the text in the newspaper to be a certain line
            MaxNewspaperA = maxInfoA;
        }
        else if (MichaelDPOne.value == 2)
        {
            Debug.Log("MAX. Drop 1 Opt 2");
            maxInfoA = "Mr. Evergreen's business partner who";// change the text in the newspaper to be a certain line
            MaxNewspaperA = maxInfoA;
        }
        else if (MichaelDPOne.value == 3)
        {
            Debug.Log("MAX. Drop 1 Opt 3");
            maxInfoA = "Mr. Evergreen's subordinate who";// change the text in the newspaper to be a certain line
            MaxNewspaperA = maxInfoA;
        }
    }
    public void MaxDropB()
    {
        if (MaxDPTwo.value == 1)
        {
            Debug.Log("MAX. Drop 2 Opt 1");
            maxInfoB = "is cold and professional,";// change the text in the newspaper to be a certain line
            MaxNewspaperB = maxInfoB;
        }
        else if (MaxDPTwo.value == 2)
        {
            Debug.Log("MAX. Drop 2 Opt 2");
            maxInfoB = " is a frigid bitch,";// change the text in the newspaper to be a certain line
            MaxNewspaperB =  maxInfoB;
        }
        else if (MaxDPTwo.value == 3)
        {
            Debug.Log("MAX. Drop 2 Opt 3");
            maxInfoB = "is a woman doing her best to make it in a man's world,";// change the text in the newspaper to be a certain line
            MaxNewspaperB = maxInfoB;
        }
    }
    public void MaxDropC()
    {
        if (MaxDPThree.value == 1)
        {
            Debug.Log("MAX. Drop 3 Opt 1");
            maxInfoC = "refused to answer questions about Mr. Evergreen's personal life.";// change the text in the newspaper to be a certain line
            MaxNewspaperC = maxInfoC;
        }
        else if (MaxDPThree.value == 2)
        {
            Debug.Log("MAX. Drop 3 Opt 2");
            maxInfoC = "did not know anything about Mr. Evergreen's personal life.";// change the text in the newspaper to be a certain line
            MaxNewspaperC = maxInfoC;
        }
        else if (MaxDPThree.value == 3)
        {
            Debug.Log("MAX. Drop 3 Opt 3");
            maxInfoC = "knew more than she could say about MR.Evergreen's personal life.";// change the text in the newspaper to be a certain line
            MaxNewspaperC = maxInfoC;
        }
    }
    public void NewspaperPrint() // using this to test things 
    {
        PlayerNewspaper = "Businessman and local hero Robert Evergreen was found dead Monday morning, having apparently fallen from a great height. The NYPD " + NovakNewspaperC + "\n \n" + "Mr. Evergreen was the CEO of Abundantia Investments. He leaves behind Jim Evergreen, his " + JimNewspaperA + ", and Julia Anderson, his" + JuliaNewspaperA + "Detective Novak," + NovakNewspaperA + NovakNewspaperB + "\n \n" + "When reached for comment, Ms. Max Elliot," + MaxNewspaperA + MaxNewspaperB + " described Mr. Evergreen as a consummate professional and an excellent boss and business partner. However, she " + MaxNewspaperC + "\n \n" + "In truth, Mr. Evergreen’s life outside of business appears to have been more complicated than he let on in his life. " + "\n \n" + "Jim " + JimNewspaperB + "and " + JimNewspaperC + ". Julia" + JuliaNewspaperB + ", and" + JuliaNewspaperC + "\n \n" + "Mr.Evergreen will be missed by many in the community, including " + MichaelNewspaperA + MichaelNewspaperB + MichaelNewspaperC;
        finalNewspaper.text = PlayerNewspaper;

    }
}


