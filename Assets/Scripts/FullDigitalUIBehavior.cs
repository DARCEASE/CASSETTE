using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

//PURPOSE: To manage the UI interface interactions 
//USAGE: place on emply gameobject and call it the game managaer 
public class FullDigitalUIBehavior : MonoBehaviour
{

    public DoubleClick openOnDClick;
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
    // 13: Newspaper Output Panel
    // 14: Drafts Folder Panel (used to be STORYWRITE)
    // 15: 
  


    void Start()
    {
        //openOnDClick = GetComponent<DoubleClick>(); //GameObject.Find("DoubleClickHandler").
        FilePanels[0].gameObject.SetActive(true); // memo panel must be active at start of game for player 
      
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    
    public void ButtonBehavior(int i) // if you press a file, activate its proper window based on the index #
    {
        //if (openOnDClick.doubleClicked == true){
            FilePanels[i].gameObject.SetActive(true);
            Debug.Log("Clicked and Opened");
        //}
            
    }

    public void ExitFile(int i) // If a file is open right now, close it
    {
        FilePanels[i].gameObject.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Youve officially left the office...");
    }
    
   
   
    



}
