using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCompleteCheckTwo : MonoBehaviour
{
    [SerializeField] NewspaperBehaviorCopy NPBC;
    [SerializeField] GameObject Char1Box, Char2Box, Char3Box, Char4Box, Char5Box, SubmitButtonGO;
    [SerializeField] bool CompletedChar1, CompletedChar2, CompletedChar3, CompletedChar4, CompletedChar5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NPBC.Char1SelectionDoneA == true && NPBC.Char1SelectionDoneB == true && NPBC.Char1SelectionDoneC == true){
                Char1Box.SetActive(false);
                CompletedChar1 = true;
            }
                
            if (NPBC.Char2SelectionDoneA == true && NPBC.Char2SelectionDoneB == true && NPBC.Char2SelectionDoneC == true){
                Char2Box.SetActive(false);
                CompletedChar2 = true;
            }
                
            if (NPBC.Char3SelectionDoneA == true && NPBC.Char3SelectionDoneB == true && NPBC.Char3SelectionDoneC == true){
                Char3Box.SetActive(false);
                CompletedChar3 = true;
            }
                
            if (NPBC.Char4SelectionDoneA == true && NPBC.Char4SelectionDoneB == true && NPBC.Char4SelectionDoneC == true){
                Char4Box.SetActive(false);
                CompletedChar4 = true;
            }
                
            if (NPBC.Char5SelectionDoneA == true && NPBC.Char5SelectionDoneB == true && NPBC.Char5SelectionDoneC == true){
                Char5Box.SetActive(false);
                CompletedChar5 = true;
            }
                
            if (CompletedChar1 == true && CompletedChar2 == true && CompletedChar3 == true && CompletedChar4 == true && CompletedChar5 == true){
                SubmitButtonGO.SetActive(true);
            }
    }
}
