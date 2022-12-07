using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

//PURPOSE: To manage the UI interface interactions FOR STORY 2
//USAGE: place on Game Manager G.O
public class StoryTwoUIBehavior : MonoBehaviour
{
    public GameObject[] S2FilePanels; // Story 2 File Panels
    // 0: Memo /Writers Letter 
    // 1: Interview Folder Panel(KEEP)
    // 2: Are you sure you want to exit button (KEEP)
    // 3: Boris (dropdown menu file)
    // 4: Boris Interview 
    // 5: Guy (dropdown menu file)
    // 6: Guy Interview
    // 7: Vito (dropdown menu file)
    // 8: Vito Interview
    // 9: BrightonBeach Man (dropdown menu file)
    // 10: Brighton Beach Man Interview
    // 11: Franz (dropdown menu file)
    // 12: Franz Interview
    // 13: Newspaper Output Panel (KEEP)
    // 14: Drafts Folder Panel (KEEP)

    // Start is called before the first frame update
    void Start()
    {
        
        S2FilePanels[0].gameObject.SetActive(true); // memo panel must be active at start of game for player 

    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonBehavior(int i) // if you press a file, activate its proper window based on the index #
    {
        //if (openOnDClick.doubleClicked == true){
        S2FilePanels[i].gameObject.SetActive(true);
        Debug.Log("S2Clicked and Opened");
        //}

    }
    public void ExitFile(int i) // If a file is open right now, close it
    {
        S2FilePanels[i].gameObject.SetActive(false);
    }
}
