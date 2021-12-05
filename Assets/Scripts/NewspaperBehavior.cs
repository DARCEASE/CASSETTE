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
    public Text NewspaperCopy;

    // establish all string variables that can be changed. and assign them on a UI text 

    //Novak
    public string novakInfoA; //container that will hold selected option for A
    public string novakInfoB; //B
    public string novakInfoC; //C

    //Jim 
    public Text jimInfoA; //container that will hold selected option  for A 
    public Text jimInfoB; //B
    public Text jimInfoC; //C

    //Julia 
    public Text juliaInfoA; //container that will hold selected option A
    public Text juliaInfoB; //B
    public Text juliaInfoC; //C

    //Michael 
    public Text michaelInfoA; //container that will hold selected option A
    public Text michaelInfoB; //B
    public Text michaelInfoC; //C

    //Max
    public Text maxInfoA; //container that will hold selected option A
    public Text maxInfoB; //B
    public Text maxInfoC; //C


    // Start is called before the first frame update
    void Start()
    {
        
        //public text = julia outcome and - string julia info if (chose a), show this string, if (chose b), if chose c - then jula outcome == "julia info"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NovakDropA()
    {
        if (NovakDPOne.value == 0) // if you choose the first option for Novak Is.. 
        {
            Debug.Log("Detective Novak is the detective assigned to the case");
            novakInfoA = "The detective assigned to the case";// change the text in the newspaper to be a certain line
            NewspaperCopy.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 25th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined." + "Novak is " + novakInfoA;

        }
        else if (NovakDPOne.value == 1)
        {
            Debug.Log("Detective Novak is the detective the case was handed off to");
            novakInfoB = "the detective the case was handed off to";// change the text in the newspaper to be a certain line
            NewspaperCopy.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 25th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined." + "Novak is " + novakInfoB;
        }
        else if (NovakDPOne.value == 2)
        {
            Debug.Log("Detective Novak is on top of the case.");
            novakInfoC = "on top of the case";// change the text in the newspaper to be a certain line
            NewspaperCopy.text = "Mr. Robert Evergreen, local hero and CEO of Abundandia Investments, was found dead on the morning of Monday, November 25th. According to an official police statement given to this reporter by Detective Novak, the manner of death is still undetermined."+ "Novak is " + novakInfoC;
        }
    }
}
