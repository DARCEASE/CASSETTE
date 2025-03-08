using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCompleteCheckTwo : MonoBehaviour
{
    Scene scene;
    [SerializeField] ChTwoNB NB2;
    [SerializeField] GameObject Char1Box, Char2Box, Char3Box, Char4Box, Char5Box, SubmitButtonGO;
    [SerializeField] bool CompletedChar1, CompletedChar2, CompletedChar3, CompletedChar4, CompletedChar5;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        SubmitButtonGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.name == "OfficialStoryTwo" || scene.name == "TESTStoryTwoScene 1" || scene.name == "HybridStoryTwo"){

            if (NB2.Ch2_Char1SelectionDoneA  && NB2.Ch2_Char1SelectionDoneB  && NB2.Ch2_Char1SelectionDoneC ){
                Char1Box.SetActive(false);
                CompletedChar1 = true;
            }
                    
            if (NB2.Ch2_Char2SelectionDoneA  && NB2.Ch2_Char2SelectionDoneB  && NB2.Ch2_Char2SelectionDoneC ){
                Char2Box.SetActive(false);
                CompletedChar2 = true;
            }
                    
            if (NB2.Ch2_Char3SelectionDoneA  && NB2.Ch2_Char3SelectionDoneB  && NB2.Ch2_Char3SelectionDoneC ){
                Char3Box.SetActive(false);
                CompletedChar3 = true;
            }
                    
            if (NB2.Ch2_Char4SelectionDoneA  && NB2.Ch2_Char4SelectionDoneB  && NB2.Ch2_Char4SelectionDoneC ){
                Char4Box.SetActive(false);
                CompletedChar4 = true;
            }
                    
            if (NB2.Ch2_Char5SelectionDoneA  && NB2.Ch2_Char5SelectionDoneB  && NB2.Ch2_Char5SelectionDoneC ){
                Char5Box.SetActive(false);
                CompletedChar5 = true;
            }
                    
            if (CompletedChar1  && CompletedChar2  && CompletedChar3  && CompletedChar4  && CompletedChar5 ){
                SubmitButtonGO.SetActive(true);
            }
        }
    }
}
