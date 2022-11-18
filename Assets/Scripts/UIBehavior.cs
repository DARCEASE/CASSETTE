using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// </summary>
public class UIBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public DoubleClick onDClick;
    public Button testButton;
    //Character Panels where drop downs are available 
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
        newsPaperPanel.SetActive(false); // disabled until fully working
        onDClick = GetComponent<DoubleClick>();

    }

    // Update is called once per frame
    void Update()
    {
        if (onDClick.doubleClicked == true){
                    novakFilePanel.SetActive(true);
                    Debug.Log("NOV");
                }
    }

    public void ExitButton()
    {
        // if you are on one of the text files and you want to close it, return to file manager
        novakFilePanel.SetActive(false);
        jimFilePanel.SetActive(false);
        juliaFilePanel.SetActive(false);
        michaelFilePanel.SetActive(false);
        maxFilePanel.SetActive(false);
    }
    public void OpenFileFolder()
    {
        //if (onDClick.doubleClicked == true)
            fileManagerPanel.SetActive(true);
    }
    public void OpenNovakFile()
    {
       
    }
    public void OpenJimFile()
    {
       // if (onDClick.doubleClicked == true)
            jimFilePanel.SetActive(true);
    }
    public void OpenJuliaFile()
    {
        //if (onDClick.doubleClicked == true)
            juliaFilePanel.SetActive(true);
    }
    public void OpenMichaelFile()
    {
        //if (onDClick.doubleClicked == true)
            michaelFilePanel.SetActive(true);
    }
    public void OpenMaxFile()
    {
        //if (onDClick.doubleClicked == true)
            maxFilePanel.SetActive(true);
    }
    public void RestartGame()
    {
        //if (onDClick.doubleClicked == true){
            //used to restart but also load in game from start scrn
            Debug.Log("restarting game commencing...");
            SceneManager.LoadScene("UpdatedGameScene");
            newsPaperPanel.SetActive(false);
        //}
    }
   
    public void SubmitReport()
    {
        //if (onDClick.doubleClicked == true)
            newsPaperPanel.SetActive(true);
    }
}
