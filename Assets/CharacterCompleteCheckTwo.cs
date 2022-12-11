using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCompleteCheckTwo : MonoBehaviour
{
    [SerializeField] StoryTwoNewspaperBehavior STNPB;
    [SerializeField] GameObject Char1Box, Char2Box, Char3Box, Char4Box, Char5Box;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (STNPB.Char1SelectionDoneA && STNPB.Char1SelectionDoneB && STNPB.Char1SelectionDoneC)
                Char1Box.SetActive(false);
            if (STNPB.Char2SelectionDoneA && STNPB.Char2SelectionDoneB && STNPB.Char2SelectionDoneC)
                Char2Box.SetActive(false);
            if (STNPB.Char3SelectionDoneA && STNPB.Char3SelectionDoneB && STNPB.Char3SelectionDoneC)
                Char3Box.SetActive(false);
            if (STNPB.Char4SelectionDoneA && STNPB.Char4SelectionDoneB && STNPB.Char4SelectionDoneC)
                Char4Box.SetActive(false);
            if (STNPB.Char5SelectionDoneA && STNPB.Char5SelectionDoneB && STNPB.Char5SelectionDoneC)
                Char5Box.SetActive(false);
    }
}
