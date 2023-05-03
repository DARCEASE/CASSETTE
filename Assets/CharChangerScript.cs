using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

/*
    The purpose of this class is to handle the changing of character names between scenes.
    This includes:
    - The Drafts window (scrolldown)
    - The Fill-in Panels (names, content displayed, options, etc)
    - And anything else that displays character names.

    Int panels are the exception since they have all the components.
*/

public class CharChangerScript : MonoBehaviour
{
    Scene scene;
    //Text objs for Drafts Window
    //[SerializeField] GameObject Drafts_Char1, Drafts_Char2, Drafts_Char3, Drafts_Char4, Drafts_Char5;
    [SerializeField] GameObject[] S1_Ints, S2_Ints, S1_Info, S2_Info, GamePanels; //Put all their info in here, then turn on/off

    [SerializeField] TMP_Text[] S1_Names, S2_Names; //Goes into drafts
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log("Name: " + SceneManager.GetActiveScene().name);

        if (scene.name == "TESTStoryOneScene 1"){

            for (int i = 0; i < S2_Info.Length; i++){
                S2_Info[i].SetActive(false);
            }
 
            for (int i = 0; i < S2_Ints.Length; i++){
                S2_Ints[i].SetActive(false);
            }

        } else if (scene.name == "TESTStoryTwoScene 1"){

            /*for (int i = 0; i < GamePanels.Length; i++){
                GamePanels[i].SetActive(false);
            }*/

            for (int i = 0; i < S1_Ints.Length; i++){
                S1_Ints[i].SetActive(false);
            }

            for (int i = 0; i < S1_Info.Length; i++){
                S1_Info[i].SetActive(false);
            }

            for (int i = 0; i < S2_Info.Length; i++){
                S2_Info[i].SetActive(true);
            }
 
            /*for (int i = 0; i < S2_Ints.Length; i++){
                S2_Ints[i].SetActive(true);
            }*/
        }
    }
}