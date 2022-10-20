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

    public GameObject[] FilePanels;
    // 0: Memo (avaialble at the start of game)
    // 1: File Manager Folder
    // 2: Doc Folder
    // 3: Audio Folder
    // 4: Novak.Exe (dropdown menu file)
    // 5: Novak Transcript
    // 6: Novak Audio
    // 7: Jim.Exe
    // 8: Jim Transcript
    // 9: Jim Audio
    // 10: Julia.Exe
    // 11: Julia Transcript
    // 12: Julia Audio
    // 13: Michael.Exe
    // 14: Michael Transcript
    // 15: Michael Audio
    // 16: Max.Exe
    // 17: Max Transcript
    // 18: Max Audio
    // 19: Newspaper Output Panel
    // 20: StoryWrite Panel 
    // 21: Are you sure you want to exit button 


    void Start()
    {
        FilePanels[0].gameObject.SetActive(true); // memo panel must be active at start of game for player 
      
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    
    public void ButtonBehavior(int i) // if you press a file, activate its proper window based on the index #
    {
        FilePanels[i].gameObject.SetActive(true);
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
