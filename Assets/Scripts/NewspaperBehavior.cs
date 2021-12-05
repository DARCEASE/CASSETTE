using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//PURPOSE:to display the submitted newspaper article based on dropdown choices 
// USAGE: place this on an empty game object in the scene 
public class NewspaperBehavior : MonoBehaviour
{
    // establish all string variables that can be changed. and assign them on a UI text 

    //Novak
    public Text novakInfoA; //container that will hold selected option for A
    public Text novakInfoB; //B
    public Text novakInfoC; //C

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
        //public tex = julia outcome and - string julia info if (chose a), show this string, if (chose b), if chose c - then jula outcome == "julia info"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
