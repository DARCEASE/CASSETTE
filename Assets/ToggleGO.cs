using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleGO : MonoBehaviour
{

    [SerializeField] GameObject GameItems;
    Scene scene;

    /*public static ToggleGO TGO_Instance;

    void Awake(){
        if (TGO_Instance == null){
            TGO_Instance = this;
            return;
        }
        Destroy (gameObject);
    }*/

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        DontDestroyOnLoad(this.gameObject);

        if (scene.name == "DEMO" ||scene.name == "OfficialStoryOne" ||scene.name == "TESTStoryOneScene 1" || scene.name == "TESTStoryTwoScene 1" || scene.name == "HybridStoryOne" || scene.name == "HybridStoryTwo" || scene.name == "ARTICLETESTSCENE"){
            Debug.Log("Scene Name Toggle: " + scene.name);
            GameItems.SetActive(true);
        } else{
            GameItems.SetActive(false);
        }
 
    }
}
