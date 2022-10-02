using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//PURPOSE: To manage the UI interface interactions 
//USAGE: place on emply gameobject and call it the game managaer 
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fileManagerPanel;
    public GameObject novakFilePanel;
    public GameObject jimFilePanel;
    public GameObject juliaFilePanel;
    public GameObject michaelFilePanel;
    public GameObject maxFilePanel;
    public GameObject newsPaperPanel;
    public GameObject memoPanel; 


    void Start()
    {
        memoPanel.SetActive(true);
        fileManagerPanel.SetActive(false);
        novakFilePanel.SetActive(false);
        jimFilePanel.SetActive(false);
        juliaFilePanel.SetActive(false);
        michaelFilePanel.SetActive(false);
        maxFilePanel.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("UpdatedGameScene");
        }

    }

    
    public void ExitButton()
    {
        // if you are on one of the text files and you want to close it, return to file manager
        fileManagerPanel.SetActive(false);
        novakFilePanel.SetActive(false);
        jimFilePanel.SetActive(false);
        juliaFilePanel.SetActive(false);
        michaelFilePanel.SetActive(false);
        maxFilePanel.SetActive(false);
        newsPaperPanel.SetActive(false);

    }public void RestartGame()

    {
        //used to restart but also load in game from start scrn
        Debug.Log("restarting game commencing...");
        SceneManager.LoadScene("UpdatedGameScene");
        newsPaperPanel.SetActive(false);
    }
    public void OpenFileFolder()
    {
        fileManagerPanel.SetActive(true);
    }
    public void OpenNovakFile()
    {
        novakFilePanel.SetActive(true);
    }
    public void OpenJimFile()
    {
        jimFilePanel.SetActive(true);
    }
    public void OpenJuliaFile()
    {
        juliaFilePanel.SetActive(true);
    }
    public void OpenMichaelFile()
    {
        michaelFilePanel.SetActive(true);
    }
    public void OpenMaxFile()
    {
        maxFilePanel.SetActive(true);
    }

    public void RestartGames()
    {
        SceneManager.LoadScene("DigitalVersion");
        newsPaperPanel.SetActive(false);
    }
}
