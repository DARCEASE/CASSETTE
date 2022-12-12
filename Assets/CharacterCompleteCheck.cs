using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCompleteCheck : MonoBehaviour
{
    Scene scene;
    [SerializeField] NewspaperBehavior NPB;
    [SerializeField] StoryTwoNewspaperBehavior STNPB;
    [SerializeField] GameObject Char1Box, Char2Box, Char3Box, Char4Box, Char5Box;
    //[SerializeField] GameObject Char1CheckedBox, Char2BoxCheckedBox, Char3BoxCheckedBox, Char4BoxCheckedBox, Char5BoxCheckedBox;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.name == "StoryOneScene" || scene.name == "HybridStoryOne"){

            if (NPB.Char1SelectionDoneA && NPB.Char1SelectionDoneB && NPB.Char1SelectionDoneC)
                Char1Box.SetActive(false);
            if (NPB.Char2SelectionDoneA && NPB.Char2SelectionDoneB && NPB.Char2SelectionDoneC)
                Char2Box.SetActive(false);
            if (NPB.Char3SelectionDoneA && NPB.Char3SelectionDoneB && NPB.Char3SelectionDoneC)
                Char3Box.SetActive(false);
            if (NPB.Char4SelectionDoneA && NPB.Char4SelectionDoneB && NPB.Char4SelectionDoneC)
                Char4Box.SetActive(false);
            if (NPB.Char5SelectionDoneA && NPB.Char5SelectionDoneB && NPB.Char5SelectionDoneC)
                Char5Box.SetActive(false);
            
        }
           
        if (scene.name == "StoryTwoScene"){
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
}
