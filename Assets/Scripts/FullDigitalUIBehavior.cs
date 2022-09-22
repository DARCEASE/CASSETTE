using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FullDigitalUIBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    //Character Panels where drop downs are available 
    public GameObject fileManagerPanel;
    public GameObject novakFilePanel;
    public GameObject jimFilePanel;
    public GameObject juliaFilePanel;
    public GameObject michaelFilePanel;
    public GameObject maxFilePanel;
    public GameObject newsPaperPanel;

    //.txt file panels where the Audio Transcripts can be found 
    public GameObject novakAudioScriptFile;
    public GameObject jimAudioScriptFile;
    public GameObject juliaAudioScriptFile;
    public GameObject michaelAudioScriptFile;
    public GameObject maxAudioScriptFile;

    //folders based on file type (documents, audio, images)
    public GameObject audioFolderPanel;
    public GameObject docFolderPanel;
    public GameObject imgFolderPanel;

    // memo available at start
    public GameObject memoPanel;

    void Start()
    {
        memoPanel.SetActive(true); // Should be set to true at the start of the game 
        // file mger 
        docFolderPanel.SetActive(false);
        fileManagerPanel.SetActive(false);
        novakFilePanel.SetActive(false);
        jimFilePanel.SetActive(false);
        juliaFilePanel.SetActive(false);
        michaelFilePanel.SetActive(false);
        maxFilePanel.SetActive(false);

        //all documents (should be off unless opened through the file manager)
        novakAudioScriptFile.SetActive(false);
        jimAudioScriptFile.SetActive(false);
        juliaAudioScriptFile.SetActive(false);
        michaelAudioScriptFile.SetActive(false);
        maxAudioScriptFile.SetActive(false);
    //all audio files 

    // all jpg files

    newsPaperPanel.SetActive(false); // disabled until fully working

    }

    // Update is called once per frame
    void Update()
    {

    }
    // items on desktop---------------------
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
    

    public void ReturntoDesktop()
    {

        memoPanel.SetActive(false);
    }
    public void CloseFileMger()
    {
        fileManagerPanel.SetActive(false);
    }
    public void OpenMemo()
    {
        memoPanel.SetActive(true);

    }
    public void OpenDocFolder()
    {
        docFolderPanel.SetActive(true);
    }

    // items in DOCUMENTS folder ---------------------
    public void NovakTranscript()
    {
        novakAudioScriptFile.SetActive(true);
    }
    public void JimTranscript()
    {
        jimAudioScriptFile.SetActive(true);
    }
    public void JuliaTranscript()
    {
        juliaAudioScriptFile.SetActive(true);
    }
    public void MichaelTranscript()
    {
        michaelAudioScriptFile.SetActive(true);
    }
    public void MaxTranscript()
    {
        maxAudioScriptFile.SetActive(true);
    }



    // HOW TO END GAME---------------
    public void SubmitReport()
    {
        newsPaperPanel.SetActive(true);
    }
}
