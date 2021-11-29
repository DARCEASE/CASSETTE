using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PURPOSE: To maneuver through alll of the UI within the scene 
//USAGE:Place on game manager object 

public class GameManager : MonoBehaviour
{
    //main panels 
    public GameObject computerPanel;
    public GameObject notepadPanel;

    //additional panels within computer view 
    public GameObject personOnePanel;
    public GameObject personTwoPanel;
    public GameObject personThreePanel;
    public GameObject personFourPanel;
    public GameObject personFivePanel;



    // Start is called before the first frame update
    void Start()
    {
        //make sure all panels are inactive at the start of the game 
        notepadPanel.SetActive(false);
        computerPanel.SetActive(true);
        personOnePanel.SetActive(false);
        personTwoPanel.SetActive(false);
        personThreePanel.SetActive(false);
        personFourPanel.SetActive(false);
        personFivePanel.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }

    //if you click the back button, deactivate the panel that youre on.
    public void BackButton()
    {
        notepadPanel.SetActive(false);
        computerPanel.SetActive(false);
        personOnePanel.SetActive(false);
        personTwoPanel.SetActive(false);
        personThreePanel.SetActive(false);
        personFourPanel.SetActive(false);
        personFivePanel.SetActive(false);

    }
    //if you click on the computer, then activate the computer panel 
    public void ActivateComputer()
    {
        computerPanel.SetActive(true);
        personOnePanel.SetActive(true);
        notepadPanel.SetActive(true);

    }

    // if youre in the computer panel, and you select person 2, activate that panel 
    public void PersonTwoFile()
    {
        personOnePanel.SetActive(false);
        personTwoPanel.SetActive(true);
        personThreePanel.SetActive(false);
        personFourPanel.SetActive(false);
        personFivePanel.SetActive(false);
        
    }
    // if youre in the computer panel, and you select person 3, activate that panel 
    public void PersonThreeFile()
    {
        personOnePanel.SetActive(false);
        personTwoPanel.SetActive(false);
        personThreePanel.SetActive(true); 
        personFourPanel.SetActive(false);
        personFivePanel.SetActive(false);
    }
    // if youre in the computer panel, and you select person 4, activate that panel 
    public void PersonFourFile()
    {
        personOnePanel.SetActive(false);
        personTwoPanel.SetActive(false);
        personThreePanel.SetActive(false);
        personFourPanel.SetActive(true);
        personFivePanel.SetActive(false);
    }
    // if youre in the computer panel, and you select person 5, activate that panel 
    public void PersonFiveFile()
    {
        personOnePanel.SetActive(false);
        personTwoPanel.SetActive(false);
        personThreePanel.SetActive(false);
        personFourPanel.SetActive(false);
        personFivePanel.SetActive(true);
    }
    // if youre in the computer panel, and you select person 1, activate that panel 
    public void PersonOneFile()
    {
        personOnePanel.SetActive(true);
        personTwoPanel.SetActive(false);
        personThreePanel.SetActive(false);
        personFourPanel.SetActive(false);
        personFivePanel.SetActive(false);
    }
    // if you click on the note pad, activate the notepad panel 
    public void ActivateNotePad()
    {
        notepadPanel.SetActive(true);
    }

}
