using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCompleteCheck : MonoBehaviour
{
    //Can be used across all of the cases
    [SerializeField] NewspaperBehavior NPB;
    [SerializeField] GameObject Char1Box, Char2Box, Char3Box, Char4Box, Char5Box;
    //[SerializeField] GameObject Char1CheckedBox, Char2BoxCheckedBox, Char3BoxCheckedBox, Char4BoxCheckedBox, Char5BoxCheckedBox;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NPB.Char1SelectionDoneA && NPB.Char1SelectionDoneB && NPB.Char1SelectionDoneC)
            Char1Box.SetActive(false);
        if (NPB.Char1SelectionDoneA && NPB.Char2SelectionDoneB && NPB.Char2SelectionDoneC)
            Char2Box.SetActive(false);
        if (NPB.Char3SelectionDoneA && NPB.Char3SelectionDoneB && NPB.Char3SelectionDoneC)
            Char3Box.SetActive(false);
        if (NPB.Char4SelectionDoneA && NPB.Char4SelectionDoneB && NPB.Char4SelectionDoneC)
            Char4Box.SetActive(false);
        if (NPB.Char5SelectionDoneA && NPB.Char5SelectionDoneB && NPB.Char5SelectionDoneC)
            Char5Box.SetActive(false);    
    }
}
