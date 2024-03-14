using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCompleteCheck : MonoBehaviour
{
    Scene scene;
    [SerializeField] NewspaperBehavior NPB;
    [SerializeField] NewspaperBehaviorCopy NPBC;
    [SerializeField] GameObject Char1Box, Char2Box, Char3Box, Char4Box, Char5Box, SubmitButtonGO;

    [SerializeField] bool CompletedChar1, CompletedChar2, CompletedChar3, CompletedChar4, CompletedChar5;
    //[SerializeField] GameObject Char1CheckedBox, Char2BoxCheckedBox, Char3BoxCheckedBox, Char4BoxCheckedBox, Char5BoxCheckedBox;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        //Debug.Log(scene.name);
        SubmitButtonGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        /* if (scene.name == "HybridStoryOne"){
            
            if (NPB.Char1SelectionDoneA && NPB.Char1SelectionDoneB && NPB.Char1SelectionDoneC){
                Char1Box.SetActive(false);
                CompletedChar1 = true;
            }
                
            if (NPB.Char2SelectionDoneA && NPB.Char2SelectionDoneB && NPB.Char2SelectionDoneC){
                Char2Box.SetActive(false);
                CompletedChar2 = true;
            }
                
            if (NPB.Char3SelectionDoneA && NPB.Char3SelectionDoneB && NPB.Char3SelectionDoneC){
                Char3Box.SetActive(false);
                CompletedChar3 = true;
            }
                
            if (NPB.Char4SelectionDoneA && NPB.Char4SelectionDoneB && NPB.Char4SelectionDoneC){
                Char4Box.SetActive(false);
                CompletedChar4 = true;
            }
                
            if (NPB.Char5SelectionDoneA && NPB.Char5SelectionDoneB && NPB.Char5SelectionDoneC){
                Char5Box.SetActive(false);
                CompletedChar5 = true;
            }
                
            if (CompletedChar1 == true && CompletedChar2 == true && CompletedChar3 == true && CompletedChar4 == true && CompletedChar5 == true){
                SubmitButtonGO.SetActive(true);
            }
        } */
           
        if (scene.name == "OfficialStoryOne" || scene.name == "TESTStoryOneScene 1" || scene.name == "HybridStoryOne"){
            
            if (NPBC.Char1SelectionDoneA && NPBC.Char1SelectionDoneB && NPBC.Char1SelectionDoneC){
                Char1Box.SetActive(false);
                CompletedChar1 = true;
            }
                
            if (NPBC.Char2SelectionDoneA && NPBC.Char2SelectionDoneB && NPBC.Char2SelectionDoneC){
                Char2Box.SetActive(false);
                CompletedChar2 = true;
            }
                
            if (NPBC.Char3SelectionDoneA && NPBC.Char3SelectionDoneB && NPBC.Char3SelectionDoneC){
                Char3Box.SetActive(false);
                CompletedChar3 = true;
            }
                
            if (NPBC.Char4SelectionDoneA && NPBC.Char4SelectionDoneB && NPBC.Char4SelectionDoneC){
                Char4Box.SetActive(false);
                CompletedChar4 = true;
            }
                
            if (NPBC.Char5SelectionDoneA && NPBC.Char5SelectionDoneB && NPBC.Char5SelectionDoneC){
                Char5Box.SetActive(false);
                CompletedChar5 = true;
            }
                
            if (CompletedChar1 == true && CompletedChar2 == true && CompletedChar3 == true && CompletedChar4 == true && CompletedChar5 == true){
                SubmitButtonGO.SetActive(true);
            }

            if (scene.name == "DEMO"){
                if (NPBC.Char1SelectionDoneA && NPBC.Char1SelectionDoneB && NPBC.Char1SelectionDoneC){
                Char1Box.SetActive(false);
                CompletedChar1 = true;
                }
                    
                if (NPBC.Char2SelectionDoneA && NPBC.Char2SelectionDoneB && NPBC.Char2SelectionDoneC){
                    Char2Box.SetActive(false);
                    CompletedChar2 = true;
                }
                    
                if (CompletedChar1 == true && CompletedChar2 == true){
                    SubmitButtonGO.SetActive(true);
                }

            }
        }
    }
}
