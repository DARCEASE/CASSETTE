using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleGO : MonoBehaviour
{

    [SerializeField] GameObject GameItems;
    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        DontDestroyOnLoad(this.gameObject);

        if (scene.name == "TESTStoryOneScene 1" || scene.name == "TESTStoryTwoScene 1" || scene.name == "HybridStoryOne" || scene.name == "HybridStoryTwo" ){
            Debug.Log("Scene Name Toggle: " + scene.name);
            GameItems.SetActive(true);
        } else{
        //if (scene.name == "ToStoryTwo" || scene.name == "EndScene"){
            GameItems.SetActive(false);
        }
 
    }
}
