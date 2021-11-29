using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBehaviorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fileManagerPanel;
    public GameObject novakFilePanel;
    public GameObject jimFilePanel;
    public GameObject juliaFilePanel;
    public GameObject michaelFilePanel;
    public GameObject maxFilePanel;


    void Start()
    {
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
}
