using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using TMPro;

//PURPOSE: To manage the UI interface interactions 
//USAGE: place on emply gameobject and call it the game managaer 
public class FullDigitalUIBehavior : MonoBehaviour
{
    [SerializeField] private RectTransform RT; 
    //public DoubleClick openOnDClick;
    public GameObject[] FilePanels;
    // 0: Memo (avaialble at the start of game)
    // 1: Interview Folder Panel
    // 2: Are you sure you want to exit button 
    // 3: Novak (dropdown menu file)
    // 4: Novak Interview 
    // 5: Jim (dropdown menu file)
    // 6: Jim Interview
    // 7: Julia (dropdown menu file)
    // 8: Julia Interview
    // 9:  Michael (dropdown menu file)
    // 10: Michael Interview
    // 11: Max (dropdown menu file)
    // 12: Max Interview
    // 13: Draft Folder (again?) Dint touch it so that I dont break anything
    // 14: Newspaper Output Panel
    // 15: Exit Panel (again?)
    // 16: Settings Menu 
    // 17: Analytics App Panel
    // 18: Messages Panel
    // 19: Char1 Int Folder
    // 20: Char2 Int Folder
    // 21: Char3 Int Folder
    // 22: Char4 Int Folder
    // 23: Char5 Int Folder

    public TMP_Text[] Messages; // Full View Texts in messages panel
    public TMP_Text MsgAppTxt;
    public bool _clicked;
    public MessageScrollController msc;

    //public GameObject analyticsWindow;
    


    // 0: Memo Text
    // 1: Side Message 


    void Start()
    {
        //openOnDClick = GetComponent<DoubleClick>(); //GameObject.Find("DoubleClickHandler").
       // FilePanels[0].gameObject.SetActive(true); // memo panel must be active at start of game for player
       /* if (analyticsWindow == null){
            analyticsWindow = GameObject.FindWithTag("AnalyticsWindow");
        }
        analyticsWindow.SetActive(false);
        */
      
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    
    public void ButtonBehavior(int i) // if you press a file, activate its proper window based on the index #
    {
        //if (openOnDClick.doubleClicked == true){
        RT = FilePanels[i].GetComponent<RectTransform>();
        RT.SetAsLastSibling(); //Push panel to the center of the canvas and in front maybe do this with sorting layer??? 
        FilePanels[i].gameObject.SetActive(true);
        //Debug.Log("Clicked and Opened");
        //}
            
    }

    /*public void AnalyticsButton(){
        analyticsWindow.SetActive(true);
    }*/

    public void ExitFile(int i) // If a file is open right now, close it
    {
        FilePanels[i].gameObject.SetActive(false);
    }

    

    public void MessageBtnBehavior(int x) // in messages app, as you click a button in the inbox, you should be able to expand it 
    {
        for (int i = 0; i < Messages.Length; i++) //for each element in the list, as long as i is less than the length of the list DONT HALT!!! Unless youre at the end <3
        {
            if (x == i) // if x = to the items in the list - then open up the text related text 
            {   
                Messages[i].gameObject.SetActive(true);
                msc.SBFunc();
               
            }
            else // if not the assigned text then turn it off <3 
            {
                Messages[i].gameObject.SetActive(false);
                msc.SBFunc();
            }
        }

        
    }

    public void QuitGame()
    {
        //Debug.Log("The Editor has left the office...");
        Application.Quit();
    }



}


