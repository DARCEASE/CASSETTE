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

    //text Containers
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
        if (NovakDPOne.value == 0) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 1 Opt 3");
            novakInfoA = "The detective assigned to the case.";// change the text in the newspaper to be a certain line
            NovakNewspaperA.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 27th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined." + " Detective Novak is " + novakInfoA;
            
        }
        else if (NovakDPOne.value == 1)
        {
            Debug.Log("NOV. Drop 1 Opt 2");
            novakInfoB = "the detective the case was handed off to.";// change the text in the newspaper to be a certain line
            NovakNewspaperA.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 27th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined." + "Detective Novak is " + novakInfoB;
        }
        else if (NovakDPOne.value == 2)
        {
            Debug.Log("NOV. Drop 1 Opt 3");
            novakInfoC = "on top of the case.";// change the text in the newspaper to be a certain line
            NovakNewspaperA.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 27th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined."+ " Detective Novak is " + novakInfoC ;
        }
    }
    public void NovakDropB() // WHO second dropdown for Novak
    {
        if (NovakDPTwo.value == 0) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 2 Opt 1");
            novakInfoB = "is passionate about getting justice.";// change the text in the newspaper to be a certain line
            NovakNewspaperB.text = "Novak " + novakInfoB;
        }
        else if (NovakDPTwo.value == 1)
        {
            Debug.Log("NOV. Drop 2 Opt 2");
            novakInfoB = "is determined to uncover all the facts.";// change the text in the newspaper to be a certain line
            NovakNewspaperB.text = "Novak " + novakInfoB; 
        }
        else if (NovakDPTwo.value == 2)
        {
            Debug.Log("NOV. Drop 2 Opt 3");
            novakInfoB = "is taking a passive stance towards solving the case.";// change the text in the newspaper to be a certain line
            NovakNewspaperB.text = "Novak " + novakInfoB ;
        }
    }
    public void NovakDropC()
    {
        if (NovakDPThree.value == 0) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("NOV. Drop 3 Opt 1");
            novakInfoC = "Novak seems more interested in gossip than finidn the truth.";// change the text in the newspaper to be a certain line
            NovakNewspaperC.text = "While it is clear that Mr. Evergreen’s death was the apparent result of a fall from a great height, the circumstances of that fall are the subject of an active and ongoing investigation, and the NYPD does not wish to speculate on those circumstances at this time." +  "But " + novakInfoC;
        }
        else if (NovakDPThree.value == 1)
        {
            Debug.Log("NOV. Drop 3 Opt 2");
            novakInfoC = "Novak is determined to uncover the thruth, no matter what.";// change the text in the newspaper to be a certain line
            NovakNewspaperC.text = "While it is clear that Mr. Evergreen’s death was the apparent result of a fall from a great height, the circumstances of that fall are the subject of an active and ongoing investigation, and the NYPD does not wish to speculate on those circumstances at this time."  + "But " + novakInfoC;
          
        }
        else if (NovakDPThree.value == 2)
        {
            Debug.Log("NOV. Drop 3 Opt 3");
            novakInfoC = "Novak is following up on any and all leads.";// change the text in the newsaper to be a certain line
            NovakNewspaperC.text = "While it is clear that Mr. Evergreen’s death was the apparent result of a fall from a great height, the circumstances of that fall are the subject of an active and ongoing investigation, and the NYPD does not wish to speculate on those circumstances at this time." + "But " + novakInfoC;
        }
    }

    //JIM 
    public void JimDropA()
    {

    }
    public void JimDropB()
    {

    }
    public void JimDropC()
    {
        /*
         // TEMPLATE FOR ALL CHARS AND DROPDOWNS
        if (Char_NameDPThree.value == 0) // 3rd dropdown
        {
            Debug.Log("Char_Name. Drop 3 Opt 1");
            Char_NameDPInfoC = "";// change the text in the newspaper to be a certain line
            Char_NameDPNewspaperC.text = "" + "And " + Char_NameDPInfoC;
        }
        else if (Char_NameDPThree.value == 1)
        {
            Debug.Log("Char_Name. Drop 3 Opt 2");
            Char_NameDPInfoC = "";// change the text in the newspaper to be a certain line
            Char_NameNewspaperC.text = "" + "And " + Char_NameInfoC;
        }
        else if (Char_NameDPThree.value == 2)
        {
            Debug.Log("Char_Name. Drop 3 Opt 3");
            Char_NameInfoC = "";// change the text in the newsaper to be a certain line
            Char_NameNewspaperC.text = "" + "And " + Char_NameInfoC;
        }*/
    }

    //JULIA 

    public void JuliaDropA()
    {

    }
    public void JuliaDropB()
    {

    }
    public void JuliaDropC()
    {

    }

    //MICHAEL 
    public void MichaelDropA()
    {

    }
    public void MichaelDropB()
    {

    }
    public void MichaelDropC()
    {

    }

    //MAX
    public void MaxDropA()
    {

    }
    public void MaxDropB()
    {

    }
    public void MaxDropC()
    {

    }
}
